using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
