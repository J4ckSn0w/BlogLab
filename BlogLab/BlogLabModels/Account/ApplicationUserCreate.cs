using System;
using System.ComponentModel.DataAnnotations;

namespace BlogLabModels.Account
{
    public class ApplicationUserCreate: ApplicationUserLogin
    {
        [MinLength(10, ErrorMessage = "Must be at least 10-30 characters")]
        [MaxLength(30, ErrorMessage = "Must be at least 10-30 characters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is requiered")]
        [MinLength(30, ErrorMessage = "Must be at least 30 characters")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}
