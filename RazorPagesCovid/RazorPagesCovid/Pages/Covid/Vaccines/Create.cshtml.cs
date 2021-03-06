using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesCovid.Data;
using RazorPagesCovid.Models;

namespace RazorPagesCovid.Pages.Covid.Vaccines
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public CreateModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vaccine Vaccine { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vaccine.Add(Vaccine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
