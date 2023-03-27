using CadastroTabelasRelacionadas.Dados;
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
        public ActionResult Index()
        {
            return View();
        }

        // GET: PermissaoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PermissaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermissaoController/Create
        [HttpPost]
        
        public ActionResult Create(IFormCollection collection)
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

        // GET: PermissaoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PermissaoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
