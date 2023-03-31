using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Entrar()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Entrar(string login, string senha)
        {
            return Redirect("/");
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("/Login/Entrar");
        }
    }
}
