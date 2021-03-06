﻿using System.ComponentModel.DataAnnotations;

namespace Authentication.Api.Model
{
    public class SignInModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
