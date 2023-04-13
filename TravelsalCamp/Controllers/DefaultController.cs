using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
