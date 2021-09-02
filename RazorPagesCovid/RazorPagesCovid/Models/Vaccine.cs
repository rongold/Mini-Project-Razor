using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCovid.Models
{
    public class Vaccine
    {
        [Key]
        public int VaccineId { get; set; }
        
        [Display(Name = "Vaccine Name"), Required]
        public string VaccineName { get; set; }

        
        [Display(Name = "Date of Release"), DataType(DataType.Date)]
        public DateTime DateOfRelease { get; set; }

        
        [Display(Name = "Company Name"), Required]
        public string CompanyName { get; set; }


    }
}