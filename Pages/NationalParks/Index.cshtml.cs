using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace wtamucis3312final.Pages.NationalParks
{
    public class IndexModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public IndexModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        public IList<NationalPark> NationalPark { get; set; } = default!;

        // Paging support
        // PageNum is the current page number we are on
        // PageSize is how many records will be displayed per page.
        // PageNum needs BindProperty because the user decides which page we are on.
        // The user selects the page number
        // SupportsGet = true allows us to pass the PageNum through the URL with an HTTP Get Parameter
        // This is necessary, because page numbers are not passed through normal forms
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int MaxPageNum =>
            (int)Math.Ceiling(_context.NationalParks.Count() / (double)PageSize);

        public async Task OnGetAsync()
        {
            NationalPark = await _context.NationalParks
                .Skip((PageNum - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}
