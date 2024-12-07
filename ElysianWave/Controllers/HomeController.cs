using ElysianWave.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ElysianWave.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.backGround = "~/圖片/浪鯨背景.jpg";
            return View();
        }

        public async Task<IActionResult> AboutUs()
        {
            ViewBag.backGround = "~/圖片/浪鯨背景.jpg";
            return View();
        }

        public async Task<IActionResult> HapinessSky()
        {
            ViewBag.backGround = "~/圖片/極浪天空true.png";
            return View();
        }

        public async Task<IActionResult> BlackWave()
        {
            ViewBag.backGround = "~/圖片/黑浪背景.jpg";
            return View();
        }

        public async Task<IActionResult> DrawPage()
        {
            ViewBag.backGround = "~/圖片/黑浪背景.jpg";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
