using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCovid.Models
{
    public class Apppointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(1000)]
        public string Location { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Appointment")]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        [Display(Name = "Vaccine")]
        public int VaccineId { get; set; }

        [ForeignKey("VaccineId")]
        public virtual Vaccine Vaccine { get; set; }
        [Required]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        public virtual User user { get; set; }

    }
}