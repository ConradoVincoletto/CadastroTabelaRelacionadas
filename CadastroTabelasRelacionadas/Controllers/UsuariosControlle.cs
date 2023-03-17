﻿using CadastroTabelasRelacionadas.Dados;
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
        public ActionResult Index()
        {
            return View(db.usuarios.ToList());
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
            return View();
        }

        // POST: UsuariosControlle/Edit/5
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

        // GET: UsuariosControlle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosControlle/Delete/5
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
