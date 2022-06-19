using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_healthAppointment.Models.ViewModels
{
    public class RegisterViewModel
    {

        [Required]
        public String Name { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "the {0} must be at least {2} characters long.", MinimumLength = 6)]
        public String Password{ get; set; }
       
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password and Confirm Password do not Match.")]
        public String ConfirmPassword { get; set; }
        [Required]

        public String RoleName { get; set; }
    }
}
