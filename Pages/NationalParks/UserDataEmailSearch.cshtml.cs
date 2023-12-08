using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Microsoft.AspNetCore.Razor.Language.Extensions;

namespace wtamucis3312final.Pages.NationalParks
{
    public class UserDataEmailSearchModel : PageModel
    {
        private readonly ILogger<UserDataEmailSearchModel> _logger;
        private readonly FinalDbContext _context;

        public UserDataEmailSearchModel(
            FinalDbContext context,
            ILogger<UserDataEmailSearchModel> logger
        )
        {
            _context = context;
            _logger = logger;
        }

        // [BindProperty]
        // public IList<UserData> UserData { get; set; } = default!;

        [BindProperty]
        public List<UserNationalParks> UserNationalParks { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        [EmailAddress]
        public string? SearchString { get; set; } = default!;

        [BindProperty]
        public string ThisUserName { get; set; } = default!;

        public async Task OnGetAsync(int? id)
        {
            //if id != null, get the national parks associated with this id
            if (id != null)
            {
                _logger.LogInformation($"Looking at User: {id}");
                UserData? user = _context.UserData.Find(id);

                UserNationalParks = await _context.UserNationalParks
                    .Where(unp => unp.UserDataId == id) //Get any UNP with UserDataId == id
                    .Include(unp => unp.NationalPark) //Now that we have that list, include the National Park
                    .ToListAsync();

                ThisUserName = user.FirstName + " " + user.LastName;
            }

            // var userEmail = from u in _context.UserData select u;

            // if (!string.IsNullOrEmpty(SearchString))
            // {
            //     // If an email address is provided, filter user data by email
            //     userEmail = userEmail.Where(u => u.Email.Contains(SearchString));
            // }
            // // Retrieve the list of user data based on the search criteria
            // UserData = await userEmail.ToListAsync();
        }

        public async Task<IActionResult> OnPostShowUserParksAsync(string? searchstring)
        {
            _logger.LogWarning($"OnPost: UserEmail {searchstring}");

            if (SearchString == null)
            {
                return NotFound();
            }

            // find the UserData connected to the Email that was entered
            UserData? userDataToshow = await _context.UserData.FirstOrDefaultAsync(
                x => x.Email == searchstring
            );

            //If the user data entry exists then list national parks that are connected
            if (userDataToshow != null)
            {
                return RedirectToPage(new { id = userDataToshow.UserDataId });
            }
            else
            {
                _logger.LogWarning("User not conected to input");
                return Page();
            }
        }
    }
}