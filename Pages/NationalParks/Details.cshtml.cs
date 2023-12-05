using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace wtamucis3312final.Pages.NationalParks
{
    public class DetailsModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public DetailsModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        public NationalPark NationalPark { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalpark = await _context.NationalParks.FirstOrDefaultAsync(m => m.NationalParkId == id);
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
