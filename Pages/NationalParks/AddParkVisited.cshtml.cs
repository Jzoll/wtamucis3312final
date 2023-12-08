using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace wtamucis3312final.Pages.NationalParks
{
    public class AddParkVisitedModel : PageModel
    {
        private readonly ILogger<AddParkVisitedModel> _logger;

        private readonly Final.Models.FinalDbContext _context;

        public AddParkVisitedModel(
            Final.Models.FinalDbContext context,
            ILogger<AddParkVisitedModel> logger
        )
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public UserData UserData { get; set; } = default!;

        [BindProperty]
        public int? currentUserId { get; set; } = default!;

        [BindProperty]
        public List<NationalPark> NationalParks { get; set; } = default!;

        [BindProperty]
        public UserNationalParks UserNationalParks { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddParkAsync(int? id)
        {
            if (id != null)
            {
                _logger.LogInformation($"Adding Park: {id} For User: {currentUserId}");
                UserNationalParks entry = new UserNationalParks();
                entry.NationalParkId = (int)id;
                entry.UserDataId = (int)currentUserId;

                _context.UserNationalParks.Add(entry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

        public async Task OnGetAsync(int? id)
        {
            //if id != null, get the national parks associated with this id
            if (id != null)
            {
                currentUserId = id;

                //get list of visited parks
                List<int> parkList = await _context.UserNationalParks
                    .Where(unp => unp.UserDataId == currentUserId)
                    .Select(unp => unp.NationalParkId)
                    .ToListAsync();

                NationalParks = await _context.NationalParks
                    .Where(park => !parkList.Contains(park.NationalParkId))
                    .ToListAsync();

                _logger.LogInformation($"Adding Park for User: {id}");
            }
        }
    }
}
