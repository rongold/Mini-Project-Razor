using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesCovid.Data;
using RazorPagesCovid.Models;

namespace RazorPagesCovid.Pages.Covid.Appointments
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public EditModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
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
           ViewData["VaccineId"] = new SelectList(_context.Set<Vaccine>(), "VaccineId", "VaccineName");
           ViewData["UserId"] = new SelectList(_context.Set<User>(), "UserId", "FullName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Apppointment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApppointmentExists(Apppointment.AppointmentId))
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

        private bool ApppointmentExists(int id)
        {
            return _context.Apppointment.Any(e => e.AppointmentId == id);
        }
    }
}
