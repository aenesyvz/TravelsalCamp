using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
