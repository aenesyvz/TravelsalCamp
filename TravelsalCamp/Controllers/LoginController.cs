using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SignUp()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
    }
}
