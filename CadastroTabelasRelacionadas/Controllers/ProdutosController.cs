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

        public IActionResult Create(Produto collection)
        {
            try
            {
                db.produtos.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
             
        }
        public ActionResult Edit(int codigo)
        {
            return View(db.produtos.Where(x => x.Codigo == codigo).FirstOrDefault());
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        
        public ActionResult Edit(int codigo, Produto collection)
        {
            try
            {
                db.produtos.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: UsuariosControlle/Delete/5
        public ActionResult Delete(int codigo)
        {
            db.produtos.Remove(db.produtos.Where(a => a.Codigo == codigo).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
