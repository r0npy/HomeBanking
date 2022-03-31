using Microsoft.AspNetCore.Mvc;

namespace HomeBanking.Controllers
{
    public class ServiciosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
