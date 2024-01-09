using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetworkSystemShopping.Models.Product;
using NetworkSystemShopping.Services.ProductService;

namespace NetworkSystemShopping.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Add(ProductAddModel model, List<IFormFile> Image)
        {
            if (!ModelState.IsValid || Image.Count == 0)
            {
                return View(model);
            }

            var res = await productService.AddProductAsync(model, Image);

            if (!res) return BadRequest();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var product = await productService.GetProductModel(id);

            if (product is null) return BadRequest();

            return View(product);
        }
    }
}
