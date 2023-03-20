using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto db;

        public ProdutosController(Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Index(string query, string tipoPesquisa)
        {

            if (string.IsNullOrEmpty(query))
            {
                return View(db.produtos.ToList());
            }
            else if (tipoPesquisa == "Todos")
            {
                return View(db.produtos.Where(a => a.Descricao.Contains(query)));
            }            
            else
            {
                return View(db.usuarios.ToList());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Produto objeto)
        {
            
            return RedirectToAction(); 
        }
    }
}
