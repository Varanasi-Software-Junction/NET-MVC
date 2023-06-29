using Microsoft.AspNetCore.Mvc;

namespace simplemvc.Controllers
{
    public class VsjController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
