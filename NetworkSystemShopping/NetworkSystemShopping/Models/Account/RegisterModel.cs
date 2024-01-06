using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NetworkSystemShopping.Models.Account
{
    public class RegisterModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } = null!;
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = null!;
        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        [PasswordPropertyText]
        [Compare(nameof(PasswordRepeat))]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;
        [Required]
        [PasswordPropertyText]
        [Display(Name = "Repeat password")]
        public string PasswordRepeat { get; set; } = null!;
    }
}
