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
    public class IndexModel : PageModel
    {
        private readonly Final.Models.FinalDbContext _context;

        public IndexModel(Final.Models.FinalDbContext context)
        {
            _context = context;
        }

        public IList<NationalPark> NationalPark { get;set; } = default!;

        public async Task OnGetAsync()
        {
            NationalPark = await _context.NationalParks.ToListAsync();
        }
    }
}
