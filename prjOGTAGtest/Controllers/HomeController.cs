using Microsoft.AspNetCore.Mvc;
using prjOGTAGtest.Models;
using System.Diagnostics;

namespace prjOGTAGtest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GiftIndex()
        {
            CIndex cIndex = new CIndex()
            {
                商品名 = "咖啡",
                賀卡圖 = "https://prjdbgamingformshow20231219140402.azurewebsites.net/images/shop/633234ed-a8d6-4cd0-80d6-07a5e4363d5b.jpg"
            };
            return View(cIndex);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}