using Business.Concrete;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment(int destinationId)
        {
            ViewBag.destinationId = destinationId;
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {

            comment.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.Status = true;
            commentManager.Add(comment);
            return RedirectToAction("Index","Destination");

        }
    }
}
