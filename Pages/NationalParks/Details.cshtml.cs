using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace wtamucis3312final.Pages.NationalParks
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<DetailsModel> _logger;
        private readonly Final.Models.FinalDbContext _context;

        public DetailsModel(Final.Models.FinalDbContext context, ILogger<DetailsModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public NationalPark NationalPark { get; set; } = default!;

        // Let user select user data to delete
        [BindProperty]
        public int NationalParkIdToDelete { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Pull in user information. Because it is a many to many we add ".ThenInclude to code"
            var nationalpark = await _context.NationalParks
                .Include(u => u.UserNationalParks)
                .ThenInclude(uu => uu.UserData)
                .FirstOrDefaultAsync(n => n.NationalParkId == id);
            if (nationalpark == null)
            {
                return NotFound();
            }
            else
            {
                NationalPark = nationalpark;
            }
            return Page();
        }

        /*
        Goal = to delete the visitors from the parks
        The code needs do remove the chosen entry from UserNationalParks.
        UserNationalParks is made of a UserDataId and a NationalParkId.
        We have the NationalParkId because it's the page we are on and it is bound to the hidden input.
        Now we just need the UserDataId to be chosen as "asp-route-id="@user.UserData.UserDataId" from the razor page.
        */
        public async Task<IActionResult> OnPostDeleteUserAsync(int? id)
        {
            //log lets us know what's being deleted
            _logger.LogWarning($"OnPost: UserDataId {id}, DROP {NationalParkIdToDelete}");
            if (id == null)
            {
                return NotFound();
            }
            // Grabs UserNationalParks and looks for an entry that contains NationalParkId and UserDataId (id)
            UserNationalParks userNpToDelete = _context.UserNationalParks.Find(
                NationalParkIdToDelete,
                id
            );

            //If the UserNationalParks entry exists then delete it
            if (userNpToDelete != null)
            {
                _context.Remove(userNpToDelete);
                _context.SaveChanges();
            }
            else
            {
                _logger.LogWarning("User has NOT visited park");
            }

            return RedirectToPage(new { id = id });
        }
    }
}
