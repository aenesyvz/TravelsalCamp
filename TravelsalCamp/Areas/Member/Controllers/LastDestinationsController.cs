using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.Areas.Member.Controllers
{
    [Area("Member")]
    public class LastDestinationsController : Controller
    {
        private readonly IDestinationService _destinationService;
        public LastDestinationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            var values = _destinationService.GetLast4Destinations();
            return View(values);
        }
    }
}
