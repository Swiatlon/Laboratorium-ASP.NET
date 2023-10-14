using Microsoft.AspNetCore.Mvc;

namespace Laboratorium2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(Birth model)
        {
            if ((bool)!model.isValid())
            {
                return BadRequest();
            }

            return View(model);
        }
    }
}
