using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCovid.Models;

namespace RazorPagesCovid.Data
{
    public class RazorPagesCovidContext : DbContext
    {
        public RazorPagesCovidContext (DbContextOptions<RazorPagesCovidContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCovid.Models.Apppointment> Apppointment { get; set; }

        public DbSet<RazorPagesCovid.Models.User> User { get; set; }

        public DbSet<RazorPagesCovid.Models.Vaccine> Vaccine { get; set; }
    }
}
