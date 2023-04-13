using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.Default
{
    public class _StaticticsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (var context = new Context())
            {
                ViewBag.v1 = context.Destinations.Count();
                ViewBag.v2 = context.Guides.Count();
                ViewBag.v3 = 280;
            }
            return View();
        }
    }
}
