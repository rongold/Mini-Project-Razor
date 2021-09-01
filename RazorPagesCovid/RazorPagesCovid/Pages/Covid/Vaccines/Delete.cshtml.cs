using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCovid.Data;
using RazorPagesCovid.Models;

namespace RazorPagesCovid.Pages.Covid.Vaccines
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public DeleteModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vaccine Vaccine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vaccine = await _context.Vaccine.FirstOrDefaultAsync(m => m.VaccineId == id);

            if (Vaccine == null)
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

            Vaccine = await _context.Vaccine.FindAsync(id);

            if (Vaccine != null)
            {
                _context.Vaccine.Remove(Vaccine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
