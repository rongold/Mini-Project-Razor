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

                context.User.AddRange(

                    new User 
                    {
                        FirstName = "Dumble"
                        ,LastName = "Door"
                        ,Age = 78
                        ,HouseNumber = "123"
                        ,PhoneNumber = "0794453234"
                        ,StreetName = "tewewt"
                        ,PostCode = "LT3 3TT"
                    },
                        new User
                        {
                            FirstName = "Gan"
                        ,
                            LastName = "Dalf"
                        ,
                            Age = 90
                        ,
                            HouseNumber = "123"
                        ,
                            PhoneNumber = "079445499"
                        ,
                            StreetName = "Omega Land"
                        ,
                            PostCode = "LW3 3TT"
                        },

                         new User
                         {
                             FirstName = "Super"
                        ,
                             LastName = "Mario"
                        ,
                             Age = 27
                        ,
                             HouseNumber = "12"
                        ,
                             PhoneNumber = "0788453134"
                        ,
                             StreetName = "Mushroom Kingdom"
                        ,
                             PostCode = "PW3 3DD"
                         }

                    );

                context.SaveChanges();

                context.Apppointment.AddRange(

                    new Apppointment
                    { 
                        DateOfAppointment = new DateTime(2021, 09, 22)
                        , UserId = 6
                        , Location = "Mars"
                        , VaccineId = 3
                    },

                       new Apppointment
                       {
                           DateOfAppointment = new DateTime(2021, 08, 22)
                        ,
                           UserId = 7
                        ,
                           Location = "Uranus"
                        ,
                           VaccineId = 2
                       }


                    );


                context.SaveChanges();
            }
        }
    }
}