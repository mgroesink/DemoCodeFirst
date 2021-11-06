using System;
using System.ComponentModel.DataAnnotations;

namespace DemoCodeFirst.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Datum")]
        public DateTime AppointmentDate { get; set; }
        [Display(Name ="Actie")]
        public string Action { get; set; }

        // Foreign key
        public string LicensePlate { get; set; }
        
        // Navigation property
        public Vehicle Vehicle { get; set; }

    }
}