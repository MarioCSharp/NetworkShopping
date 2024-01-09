using System.ComponentModel.DataAnnotations;

namespace NetworkSystemShopping.Models.Product
{
    public class ProductAddModel
    {
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
        public byte[] Image { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        [Required]
        public int Type { get; set; }
    }
}
