using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCovid.Models
{
    public class Vaccine
    {
        [Key]
        public int VaccineId { get; set; }
        [Required]
        [Display(Name = "Vaccine Name")]
        public string VaccineName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Release")]
        public DateTime DateOfRelease { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }


    }
}