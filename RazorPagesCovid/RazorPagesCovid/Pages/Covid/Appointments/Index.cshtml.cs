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
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public IndexModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
        {
            _context = context;
        }

        public IList<Apppointment> Apppointment { get;set; }
        public int? UserId { get; set; }

        public async Task OnGetAsync()
        {
            Apppointment = await _context.Apppointment
                .Include(a => a.Vaccine)
                .Include(a => a.user).ToListAsync();
        }

        public async Task OnGetUserAsync(int? id)
        {
            UserId = id;
            Apppointment = await _context.Apppointment
                .Include(a => a.Vaccine)
                .Include(a => a.user).Where(a => a.UserId == UserId).ToListAsync();
        }
    }
}
