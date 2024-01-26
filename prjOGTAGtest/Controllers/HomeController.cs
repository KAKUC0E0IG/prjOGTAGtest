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
            CIndex cIndex = new CIndex()
            {
                商品名 = "大冰美式買12送12",
                賀卡圖 = "https://prjdbgamingformshow20231219140402.azurewebsites.net/AD/b84fc620-3824-45bb-ae2f-a7820b114a17.jpg",
                分享連結 = "https://9bdb-219-91-55-83.ngrok-free.app/home/giftindex"
            };
            return View(cIndex);
        }

        public IActionResult GiftIndex()
        {
            CIndex cIndex = new CIndex()
            {
                商品名 = "大冰美式買12送12",
                賀卡圖 = "https://prjdbgamingformshow20231219140402.azurewebsites.net/AD/b84fc620-3824-45bb-ae2f-a7820b114a17.jpg",
                分享連結 = "https://9bdb-219-91-55-83.ngrok-free.app/home/giftindex"
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