using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using CadastroTabelasRelacionadas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class UsuariosControlle : Controller
    {
        private readonly Contexto db;

        public UsuariosControlle(Contexto contexto)
        {
            db = contexto;
        }

        //Lista de permissões

        public IActionResult ListaPermissoes(int id)
        {
            ListaPermissoesModel model = new ListaPermissoesModel();
            model.TodasPermissoes = db.permissoes.ToList();
            model.Permissoesusuario = db.usuario_permissao.Where(a => a.UsuarioId == id).Include(a => a.permissao).ToList();
            return View(model);
        }
        // GET: UsuariosControlle
        public ActionResult Index(string query, string tipoPesquisa)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(db.usuarios.ToList());
            }
            else if(tipoPesquisa == "Todos")
            {
                return View(db.usuarios.Where(a => a.Login.Contains(query) || a.Nome.Contains(query)));
            }
            else if (tipoPesquisa == "PorNome")
            {
                return View(db.usuarios.Where(a => a.Nome.Contains(query)));
            }
            else if (tipoPesquisa == "PorLogin")
            {
                return View(db.usuarios.Where(a => a.Login.Contains(query)));
            }
            else
            {
                return View(db.usuarios.ToList());
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
        public ActionResult Delete(int id)
        {
            return View(db.usuarios.Where(a => a.Id == id).FirstOrDefault());
        }

        // GET: UsuariosControlle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Usuarios collection)
        {
            db.usuarios.Remove(db.usuarios.Where(a => a.Id == id).FirstOrDefault());    
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
