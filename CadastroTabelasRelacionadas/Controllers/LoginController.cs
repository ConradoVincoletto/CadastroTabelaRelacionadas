using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;

        public LoginController(Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Entrar()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Entrar(string login, string senha)
        {
            Usuarios usuarioLogado = db.usuarios.Where(a => a.Login == login && a.Senha == senha).FirstOrDefault();

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Nome));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.Id.ToString()));
            return Redirect("/");
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("/Login/Entrar");
        }
    }
}
