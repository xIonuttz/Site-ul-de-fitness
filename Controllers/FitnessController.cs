

using Microsoft.AspNetCore.Mvc;

namespace FitnessSite.Controllers
{
    public class FitnessController : Controller
    {
        public IActionResult VreauSaSlabesc()
        {
            return View();
        }

        public IActionResult VreauMasaMusculara()
        {
            return View();
        }

        public IActionResult VreauPlanAlimentar()
        {
            return View();
        }
    }
}