using Microsoft.AspNetCore.Mvc;
using NetworkSystemShopping.Services.ProductService;

namespace NetworkSystemShopping.Controllers
{
    public class StoreController : Controller
    {
        private IProductService productService;
        public StoreController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await productService.GetAllProducts());
        }

        [HttpGet]
        public async Task<IActionResult> Routers()
        {
            return View(await productService.GetRouters());
        }
        [HttpGet]
        public async Task<IActionResult> WirelessNetworkCards()
        {
            return View(await productService.GetWirelessNetworkCards());
        }
        [HttpGet]
        public async Task<IActionResult> AccessPoints()
        {
            return View(await productService.GetAccessPoints());
        }
        [HttpGet]
        public async Task<IActionResult> Cables()
        {
            return View(await productService.GetCables());
        }
        [HttpGet]
        public async Task<IActionResult> Connectors()
        {
            return View(await productService.GetConnectors());
        }
    }
}
