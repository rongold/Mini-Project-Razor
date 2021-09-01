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

        public DbSet<Apppointment> Apppointments { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
