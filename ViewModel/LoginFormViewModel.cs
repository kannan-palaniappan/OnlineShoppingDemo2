﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingDemo2.ViewModel
{
    public class LoginFormViewModel
    {

        [Required(ErrorMessage = "UserName Is Required")]
        [Display(Name = "User Name")]
        [StringLength(50)]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [Display(Name = "Password")]
        [StringLength(20)]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}