using NetworkSystemShopping.Models.Product;
using NetworkSystemShopping.Models.Store;

namespace NetworkSystemShopping.Services.ProductService
{
    public interface IProductService
    {
        Task<bool> AddProductAsync(ProductAddModel model, List<IFormFile> Image);
        Task<ProductDetailsModel> GetProductModel(int id);
        Task<List<ProductDetailsModel>> GetRouters();
        Task<List<ProductDetailsModel>> GetWirelessNetworkCards();
        Task<List<ProductDetailsModel>> GetAccessPoints();
        Task<List<ProductDetailsModel>> GetCables();
        Task<List<ProductDetailsModel>> GetConnectors();
        Task<List<ProductDetailsModel>> GetAllProducts(StoreModel filter);
    }
}
