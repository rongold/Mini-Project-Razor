using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCovid.Models
{
    public class Apppointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required,StringLength(1000),RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Location { get; set; }

        [Display(Name = "Date of Appointment"), DataType(DataType.Date)]
        public DateTime DateOfAppointment { get; set; }
        
        [Display(Name = "Vaccine"), Required]
        public int VaccineId { get; set; }

        [ForeignKey("VaccineId")]
        public virtual Vaccine Vaccine { get; set; }
        
        [Display(Name = "User ID"), Required]
        public int UserId { get; set; }

        public virtual User user { get; set; }

    }
}