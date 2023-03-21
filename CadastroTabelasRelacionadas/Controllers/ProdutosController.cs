using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using CadastroTabelasRelacionadas.Models;
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
            ProdutoModel produtoModel = new ProdutoModel();
            
            return View();
        }

        [HttpPost]

        public IActionResult Create(Produto objeto)
        {
            try
            {
                db.produtos.Add(objeto);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
             
        }
        public ActionResult Edit(int id)
        {
            return View(db.produtos.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        
        public ActionResult Edit(int id, Produto objeto)
        {
            try
            {
                db.produtos.Update(objeto);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: UsuariosControlle/Delete/5
        public ActionResult Delete(int id)
        {
            db.produtos.Remove(db.produtos.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
