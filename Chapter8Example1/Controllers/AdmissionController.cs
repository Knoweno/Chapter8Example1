using Microsoft.AspNetCore.Mvc;

namespace Chapter8Example1.Controllers
{
    public class AdmissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
