using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ElysianWave.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace ElysianWave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly ElysianWaveContext _context;
        public UserInfoController(ElysianWaveContext context)
        {
            _context = context;
        }
        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn([FromBody]UserInfomation user) {
            UserInfomation? logUser = await _context.UserInfomations.FirstOrDefaultAsync(p => p.UserAccount == user.UserAccount);
            if (logUser != null && user.UserPassword == logUser.UserPassword)
            {
                //layout獲取userId
                HttpContext.Session.SetInt32("userId", logUser.UserId);
                HttpContext.Session.SetString("userNickName", logUser.UserNickName);

                return Ok(new {success="會員登入成功",redirectUrl= Url.Action("Index","Home")});
                
            }
            else if (logUser != null && user.UserPassword != logUser.UserPassword) {
                return Ok(new { success = "帳號密碼錯誤"});
            }
            else {
                return Ok(new { success = "會員未註冊" });
            }
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] UserInfomation user) {
            await _context.UserInfomations.AddAsync(user);
            _context.SaveChanges();
            return Ok(new { success = "註冊成功" });
        }
    }
}
