using NetworkSystemShopping.Models.Product;

namespace NetworkSystemShopping.Models.Store
{
	public class StoreModel
	{
        public List<ProductDetailsModel> Products { get; set; } = null!;
        public string Brand { get; set; }
        public string PriceRange { get; set; }
        public string OrderBy { get; set; }
    }
}
