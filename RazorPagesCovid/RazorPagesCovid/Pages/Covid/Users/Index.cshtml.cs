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

namespace RazorPagesCovid.Pages.Covid.Users
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCovid.Data.RazorPagesCovidContext _context;

        public IndexModel(RazorPagesCovid.Data.RazorPagesCovidContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public SelectList GetUserName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UserName { get; set; }

        public async Task OnGetAsync()
        {
            var getPeopleNames = from u in _context.User
                         select u;
            if (!string.IsNullOrEmpty(SearchString))
            {
                getPeopleNames = getPeopleNames.Where(s => s.FirstName.Contains(SearchString) || s.LastName.Contains(SearchString));
            }
            User = await getPeopleNames.ToListAsync();
        }
    }
}
