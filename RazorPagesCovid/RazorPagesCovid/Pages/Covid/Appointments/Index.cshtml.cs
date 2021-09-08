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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public IndexModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
        {
            _context = context;
        }

        public IList<Apppointment> Apppointment { get;set; }
        public int? UserId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList GetAppointments { get; set; }


        [BindProperty(SupportsGet = true)]
        public string NameOfVaccine { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> VaccineNames = from v in _context.Vaccine
                                              orderby v.VaccineName
                                              select v.VaccineName;


            var getPeopleNames = from u in _context.Apppointment.Include(u => u.User).Include(u => u.Vaccine)
                                 select u;

            if (!string.IsNullOrEmpty(SearchString))
            {
                getPeopleNames = getPeopleNames.Where(s => s.User.FirstName.Contains(SearchString) || s.User.LastName.Contains(SearchString) || s.Location.Contains(SearchString));
            }


            if (!string.IsNullOrEmpty(NameOfVaccine))
            {
                getPeopleNames = getPeopleNames.Where(x => x.Vaccine.VaccineName == NameOfVaccine);
            }

            GetAppointments = new SelectList(await VaccineNames.Distinct().ToListAsync());
            Apppointment = await getPeopleNames.Include(a => a.Vaccine)
                .Include(a => a.User).Where(a => a.UserId == UserId).ToListAsync();
        }

		public async Task OnGetUserAsync(int? id)
		{
			UserId = id;
			Apppointment = await _context.Apppointment
				.Include(a => a.Vaccine)
				.Include(a => a.User).Where(a => a.UserId == UserId).ToListAsync();
		}
	}
}
