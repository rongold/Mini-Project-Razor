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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public DeleteModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Apppointment Apppointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Apppointment = await _context.Apppointment
                .Include(a => a.Vaccine)
                .Include(a => a.user).FirstOrDefaultAsync(m => m.AppointmentId == id);

            if (Apppointment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Apppointment = await _context.Apppointment.FindAsync(id);

            if (Apppointment != null)
            {
                _context.Apppointment.Remove(Apppointment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
