using Microsoft.AspNetCore.Mvc;

namespace AspSatu.Controllers
{
    public class KamiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
