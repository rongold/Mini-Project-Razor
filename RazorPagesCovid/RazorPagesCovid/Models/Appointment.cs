using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Apppointment
    {
        public int AppointmentId { get; set; }

        public string Location { get; set; };

        [DataType(DataType.Date)]
        public DateTime DateOfAppointment { get; set; }


        public string Vaccine { get; set; }


    }
}