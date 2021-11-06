using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models
{
    public class Vehicle
    {
        [Required]
        [Display(Name = "Kenteken")]
        [Key]
        public string LicensePlate { get; set; }
        [Display(Name = "Startdatum contract")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Kies een Camper of Caravan")]
        public string KindOfVehicle { get; set; } = "Camper";


        [Display(Name = "Einddatum contract")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public string ApplicationUserId { get; set; }
        // Navigation Property
        public ApplicationUser Owner { get; set; }

        // Navigation property
        public List<Appointment> Appointments { get; set; }
    }
}
