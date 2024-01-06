using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NetworkSystemShopping.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string LastName { get; set; } = null!;
        [Required]
        public string PhoneNumber { get; set; } = null!;
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
    }
}
