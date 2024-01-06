using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetworkSystemShopping.Data.Models;

namespace NetworkSystemShopping.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
