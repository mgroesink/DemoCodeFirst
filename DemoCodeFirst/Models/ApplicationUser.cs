using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoCodeFirst.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Voornaam")]
        public string LastName { get; set; }
        [Display(Name = "Geboortedatum")]
        public DateTime BirthDate { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(MiddleName))
                {
                    return FirstName + " " + LastName;
                }
                else
                {
                    return FirstName + " " + MiddleName + " " + LastName;
                }
            }
        }

        public List<Vehicle> Vehicles { get; set; }



    }
}