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

namespace RazorPagesCovid.Pages.Covid.Vaccines
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public IndexModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
        {
            _context = context;
        }

        public IList<Vaccine> Vaccine { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList GetVaccineNames { get; set; }


        [BindProperty(SupportsGet = true)]
        public string NameOfVaccine { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> VaccineNames = from v in _context.Vaccine
                                            orderby v.VaccineName
                                            select v.VaccineName;


            var getPeopleNames = from u in _context.Vaccine
                                 select u;

            if (!string.IsNullOrEmpty(SearchString))
            {
                getPeopleNames = getPeopleNames.Where(s => s.VaccineName.Contains(SearchString) || s.CompanyName.Contains(SearchString) || s.DateOfRelease.ToString().Contains(SearchString));
            }

            
            if (!string.IsNullOrEmpty(NameOfVaccine))
            {
                getPeopleNames = getPeopleNames.Where(x => x.VaccineName == NameOfVaccine);
            }

            GetVaccineNames = new SelectList(await VaccineNames.Distinct().ToListAsync());
            Vaccine = await getPeopleNames.ToListAsync();
        }
    }
}
