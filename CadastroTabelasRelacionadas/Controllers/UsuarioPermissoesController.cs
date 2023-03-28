using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class UsuarioPermissoesController : Controller
    {
        private readonly Contexto db;

        public UsuarioPermissoesController(Contexto contexto)
        {
            db = contexto;
        }
        [HttpGet("[controller]/[action]/{UsuarioId}/{PermissaoId}")]
        public IActionResult AdicionarPermissao(int UsuarioId, int PermissaoId)
        {
            Usuarios_Permissoes novo = new Usuarios_Permissoes();
            novo.UsuarioId = UsuarioId;
            novo.PermissaoId = PermissaoId;
            db.usuario_permissao.Add(novo);
            db.SaveChanges();
            return Redirect("/Usuarios");
        }
    }
}
