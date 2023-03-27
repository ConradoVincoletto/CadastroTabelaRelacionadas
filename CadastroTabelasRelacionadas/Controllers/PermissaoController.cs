using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class PermissaoController : Controller
    {
        private readonly Contexto db;

        public PermissaoController (Contexto contexto)
        {
            db = contexto;
        }


        // GET: PermissaoController
        public ActionResult Index(string query, string tipoPesquisa)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(db.permissoes.ToList());
            }
            else if (tipoPesquisa == "Todos")
            {
                return View(db.permissoes.Where(a => a.Descricao.Contains(query)));
            }
            else
            {
                return View(db.permissoes.ToList());
            }
        }
                
        // GET: PermissaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermissaoController/Create
        [HttpPost]        
        public ActionResult Create(Permissao objeto)
        {
            try
            {
                db.permissoes.Add(objeto);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // GET: PermissaoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PermissaoController/Edit/5
        [HttpPost]        
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissaoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PermissaoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
