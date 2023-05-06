using Business.Concrete;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
       // CommentManager commentManager = new CommentManager(new EfCommentDal());
       // [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Entities.Concretes.Comment comment)
        //{
        //    comment.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    comment.Status = true;
        //    commentManager.Add(comment);
        //    return View();
        //}
    }
}
