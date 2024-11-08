using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EDental.Data;
using EDental.Data.Models;

namespace EDental.Controllers
{
    public class IndexModel : PageModel
    {
        private readonly EDental.Data.EDentalDbContext _context;

        public IndexModel(EDental.Data.EDentalDbContext context)
        {
            _context = context;
        }

        public IList<Diagnosis> Diagnosis { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Diagnosis = await _context.Diagnosis.ToListAsync();
        }
    }
}
