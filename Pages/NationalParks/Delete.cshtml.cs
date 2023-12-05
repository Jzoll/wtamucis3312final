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
    public class DeleteModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public DeleteModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalpark = await _context.NationalParks.FindAsync(id);
            if (nationalpark != null)
            {
                NationalPark = nationalpark;
                _context.NationalParks.Remove(NationalPark);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
