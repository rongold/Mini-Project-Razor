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

            Apppointment = await _context.Apppointments
                .Include(a => a.Vaccine).FirstOrDefaultAsync(m => m.AppointmentId == id);

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

            Apppointment = await _context.Apppointments.FindAsync(id);

            if (Apppointment != null)
            {
                _context.Apppointments.Remove(Apppointment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
