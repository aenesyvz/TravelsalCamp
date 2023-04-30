using Business.Concrete;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = 1;
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = destinationManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination) {
            return View();
        }
    }
}
