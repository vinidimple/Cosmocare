using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmoApp.Models
{
    public class User_LoginViewModel
    {
        [Display(Name = "Login Id")]
        [Required]
        public string LoginID { get; set; }

        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

    }
}