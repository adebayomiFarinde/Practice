using Practice.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.Web.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        public Sex Sex { get; set; }

        [Display(Name = "Number Of Children"), Range(0, int.MaxValue)]
        public int NumberOfChildren { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
