using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final.Models;

namespace wtamucis3312final.Pages.NationalParks
{
    public class CreateModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public CreateModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public NationalPark NationalPark { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.NationalParks.Add(NationalPark);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}