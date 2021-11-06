using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models.ViewModels
{
    public class UserViewModel
    {
        // User info
        [EmailAddress]
        [Key]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // ApplicationUser info
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        public ApplicationUser ApplicationUser { get; set; }
    }
}
