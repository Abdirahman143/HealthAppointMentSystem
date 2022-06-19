using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_healthAppointment.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public String  Email { get; set; }
       
        [DataType(DataType.Password)]

        [Required]
        public String Password { get; set; }
        [Display(Name ="Remember Me?")]
        public bool RememberMe { get; set; }

    }
}
