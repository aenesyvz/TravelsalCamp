using Business.Concrete;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int destinationId)
        {
            var values = commentManager.GetAllByDestinationIdAndStatus(destinationId);
            return View(values);
        }
    }
}
