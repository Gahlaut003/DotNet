using Microsoft.AspNetCore.Mvc;

namespace Utility_v1.Controllers
{
    public class UtilityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
