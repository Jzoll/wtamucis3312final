using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace wtamucis3312final.Pages.NationalParks
{
    public class UserParkTrackerModel : PageModel
    {
        private readonly ILogger<UserParkTrackerModel> _logger;
        private readonly FinalDbContext _context;

        public UserParkTrackerModel(FinalDbContext context, ILogger<UserParkTrackerModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        // [BindProperty]
        // [Range(0, int.MaxValue)]
        // //ErrorMessage = "User ID must be a positive number"
        // [Required]
        // public int enteredUserId { get; set; } = default!;

        [BindProperty]
        public IList<UserData> UserData { get; set; } = default!;

        [BindProperty]
        public List<UserNationalParks>? UserNationalParks { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; } = default!;

        public SelectList? UserId { get; set; }

        public async Task OnGetAsync(int? id)
        {
            var userEmail = from u in _context.UserData select u;
            if (!string.IsNullOrEmpty(SearchString))
            {
                userEmail = userEmail.Where(u => u.Email.Contains(SearchString));
            }

            UserData = await userEmail.ToListAsync();
            _logger.LogWarning($"OnPost: UserEmail {SearchString}");
        }
    }
}
