﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Surfapplikation.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
