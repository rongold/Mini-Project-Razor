using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCovid.Models
{
    public class Apppointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfAppointment { get; set; }

        public int VaccineId { get; set; }

        [ForeignKey("VaccineId")]
        public virtual Vaccine Vaccine { get; set; }


    }
}