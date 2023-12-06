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
    }
}
