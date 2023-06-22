using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
