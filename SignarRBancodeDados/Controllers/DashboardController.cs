using Microsoft.AspNetCore.Mvc;

namespace SignarRBancodeDados.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
