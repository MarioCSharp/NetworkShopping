using NetworkSystemShopping.Models.Product;
using static System.Net.Mime.MediaTypeNames;

namespace NetworkSystemShopping.Services.ProductService
{
    public interface IProductService
    {
        Task<bool> AddProductAsync(ProductAddModel model, List<IFormFile> Image);
        Task<ProductDetailsModel> GetProductModel(int id);
    }
}
