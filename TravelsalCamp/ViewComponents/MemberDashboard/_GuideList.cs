using Business.Concrete;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.GetAll();
            return View(values);
        }
    }
}
