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
            ViewBag.backGround = "~/�Ϥ�/���H�I��.jpg";
            return View();
        }

        public async Task<IActionResult> AboutUs()
        {
            ViewBag.backGround = "~/�Ϥ�/���H�I��.jpg";
            return View();
        }

        public async Task<IActionResult> HapinessSky()
        {
            ViewBag.backGround = "~/�Ϥ�/�����Ѫ�true.png";
            return View();
        }

        public async Task<IActionResult> BlackWave()
        {
            ViewBag.backGround = "~/�Ϥ�/�®��I��.jpg";
            return View();
        }

        public async Task<IActionResult> DrawPage()
        {
            ViewBag.backGround = "~/�Ϥ�/�®��I��.jpg";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
