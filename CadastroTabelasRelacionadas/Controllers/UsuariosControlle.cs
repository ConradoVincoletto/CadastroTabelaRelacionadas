using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class UsuariosControlle : Controller
    {
        private readonly Contexto db;

        public UsuariosControlle(Contexto contexto)
        {
            db = contexto;
        }


        // GET: UsuariosControlle
        public ActionResult Index(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(db.usuarios.ToList());
            }
            else
            {
                return View(db.usuarios.Where(a => a.Login.Contains(query) || a.Nome.Contains(query)));
            }
        }

        // GET: UsuariosControlle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosControlle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosControlle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuarios collection)
        {
            try
            {
                db.usuarios.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosControlle/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.usuarios.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: UsuariosControlle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuarios collection)
        {
            try
            {
                db.usuarios.Update(collection);
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
            db.usuarios.Remove(db.usuarios.Where(a => a.Id == id).FirstOrDefault());    
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
