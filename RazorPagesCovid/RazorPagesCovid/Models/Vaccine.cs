using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCovid.Models
{
    public class Vaccine
    {
        [Key]
        public int VaccineId { get; set; }

        public string VaccineName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfRelease { get; set; }


        public string CompanyName { get; set; }


    }
}