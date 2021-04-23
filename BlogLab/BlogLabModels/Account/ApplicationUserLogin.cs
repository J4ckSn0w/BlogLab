using System;
using System.ComponentModel.DataAnnotations;

namespace BlogLabModels.Account
{
    public class ApplicationUserLogin
    {
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Must be at least 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be at least 10-50 characters")]
        public string Password { get; set; }
    }
}
