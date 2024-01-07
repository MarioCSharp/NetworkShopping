using Microsoft.EntityFrameworkCore;
using NetworkSystemShopping.Data;
using NetworkSystemShopping.Data.Models;
using NetworkSystemShopping.Models.Product;

namespace NetworkSystemShopping.Services.ProductService
{
    public class ProductService : IProductService
    {
        private ApplicationDbContext context;
        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> AddProductAsync(ProductAddModel model, List<IFormFile> Image)
        {
            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Quantity = model.Quantity,
            };

            foreach (var file in Image)
            {
                if (file.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await file.CopyToAsync(stream);
                        product.Image = stream.ToArray();
                    }
                }
            }

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

            return await context.Products.ContainsAsync(product);
        }

        public async Task<ProductDetailsModel> GetProductModel(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product == null) return null;

            var base64 = Convert.ToBase64String(product.Image);
            var imgSrc = string.Format("data:image/gif;base64,{0}", base64);

            return new ProductDetailsModel
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = imgSrc
            };
        }
    }
}
