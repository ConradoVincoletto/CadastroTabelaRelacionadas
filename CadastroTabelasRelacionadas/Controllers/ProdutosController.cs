using CadastroTabelasRelacionadas.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class ProdutosController : Controller
    {
        public static List<Produto> listaProdutos = new List<Produto>();
        public IActionResult Index()
        {
            return View(listaProdutos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Produto objeto)
        {
            listaProdutos.Add(objeto);
            return RedirectToAction("Index"); 
        }
    }
}
