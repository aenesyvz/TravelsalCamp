using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
  
        public IViewComponentResult Invoke()
        {
            using(var context = new Context())
            {
                ViewBag.v1 = context.Destinations.Count();
                ViewBag.v2 = context.Users.Count();
                return View();
            }
           
        }
    }
}
