using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCovid.Models
{
    public class Apppointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required,StringLength(1000, MinimumLength = 1),RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Requires a Capital letter at the begining and can only contain letters, Minimum Length is 1")]
        public string Location { get; set; }

        [Display(Name = "Date of Appointment"), DataType(DataType.Date)]
        public DateTime DateOfAppointment { get; set; }

        [Display(Name = "Minium wait of next Appointment"), DataType(DataType.Date)]
        public DateTime NextDateOfAppointment => DateOfAppointment.AddDays(60);

        [Display(Name = "Vaccine"), Required]
        public int VaccineId { get; set; }

        [ForeignKey("VaccineId")]
        public virtual Vaccine Vaccine { get; set; }
        
        [Display(Name = "User ID"), Required]
        public int UserId { get; set; }

        public virtual User user { get; set; }

    }
}