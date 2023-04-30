using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
