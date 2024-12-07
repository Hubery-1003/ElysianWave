using Microsoft.AspNetCore.Mvc;

namespace ElysianWave.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> LogInPage()
        {
            ViewBag.backGround = "~/圖片/浪鯨背景.jpg";
            return View();
        }

        public async Task<IActionResult> RegisterPage()
        {
            ViewBag.backGround = "~/圖片/浪鯨背景.jpg";
            return View();
        }
    }
}
