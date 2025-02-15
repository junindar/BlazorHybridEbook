﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLogin.Entity
{
    public class User
    {
        
        [Display(Name = "User name")]
        public string Username { get; set; }

        
        [Display(Name = "Nama Pengguna")]
        public string Nama { get; set; }

       
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        
        [Display(Name = "User Role")]
        public string Role { get; set; }

    }
}
