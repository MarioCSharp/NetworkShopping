using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkSystemShopping.Data.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;
        [Required]
        public string ProductIds { get; set; } = null!;
    }
}
