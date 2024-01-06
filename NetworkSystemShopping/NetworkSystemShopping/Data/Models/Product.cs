using System.ComponentModel.DataAnnotations;

namespace NetworkSystemShopping.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Description { get; set; } = null!;
        [Required]
        public double Price { get; set; }
        [Required]
        public byte[] Image { get; set; } = null!;
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
