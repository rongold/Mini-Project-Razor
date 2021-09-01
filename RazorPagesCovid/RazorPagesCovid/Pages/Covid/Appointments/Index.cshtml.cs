using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCovid.Data;
using RazorPagesCovid.Models;

namespace RazorPagesCovid.Pages.Covid.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCovidContext _context;

        public IndexModel(RazorPagesCovidContext context)
        {
            _context = context;
        }

        public IList<Apppointment> Apppointment { get;set; }

        public async Task OnGetAsync()
        {
            Apppointment = await _context.Apppointments
                .Include(a => a.Vaccine).ToListAsync();
        }
    }
}
