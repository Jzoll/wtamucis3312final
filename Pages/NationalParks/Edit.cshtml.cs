using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace wtamucis3312final.Pages.NationalParks
{
    public class EditModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public EditModel(Final.Models.FinalDbContext context)
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

            var nationalpark = await _context.NationalParks.FirstOrDefaultAsync(
                m => m.NationalParkId == id
            );
            if (nationalpark == null)
            {
                return NotFound();
            }
            NationalPark = nationalpark;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostEditParkAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(NationalPark).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NationalParkExists(NationalPark.NationalParkId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NationalParkExists(int id)
        {
            return _context.NationalParks.Any(e => e.NationalParkId == id);
        }
    }
}
