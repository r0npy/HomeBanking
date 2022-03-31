using HomeBanking.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeBanking.Controllers
{
    public class CuentasController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult Autenticar(Login login)
        {
            if (login.Documento == 2377607 && login.Cuenta == 200124409 && login.Password == 147258)
                return RedirectToAction("index", "servicios");
            else
                return RedirectToAction("login", "cuentas");
        }
    }
}
