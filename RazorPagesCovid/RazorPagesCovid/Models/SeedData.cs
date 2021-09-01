using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesCovid.Data;
using System;
using System.Linq;

namespace RazorPagesCovid.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesCovidContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesCovidContext>>()))
            {
                // Look for any vaccines.
                if (context.Vaccine.Any())
                {
                    return;   // DB has been seeded
                }

                context.Vaccine.AddRange(
                    new Vaccine
                    {
                        VaccineName = "Pfizer-BioNTech",
                        CompanyName = "Pfizer, Inc., and BioNTech",
                        DateOfRelease = new DateTime(2020, 12, 2)
                    },

                    new Vaccine
                    {
                        VaccineName = "Moderna",
                        CompanyName = "ModernaTX, Inc.",
                        DateOfRelease = new DateTime(2021, 4, 13)
                    },

                    new Vaccine
                    {
                        VaccineName = "Johnson & Johnson’s Janssen",
                        CompanyName = " Janssen Pharmaceuticals Companies of Johnson & Johnson",
                        DateOfRelease = new DateTime(2021, 5, 28)
                    },

                    new Vaccine
                    {
                        VaccineName = "Oxford/AstraZeneca",
                        CompanyName = "AstraZeneca-SKBio and the Serum Institute of India",
                        DateOfRelease = new DateTime(2020, 12, 30)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}