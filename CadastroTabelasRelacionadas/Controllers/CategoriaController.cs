﻿using CadastroTabelasRelacionadas.Dados;
using CadastroTabelasRelacionadas.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly Contexto db;

        public CategoriaController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: CategoriaController
        public ActionResult Index(string query, string tipoPesquisa)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(db.categorias.ToList());
            }
            else if (tipoPesquisa == "Todos")
            {
                return View(db.categorias.Where(a => a.Descricao.Contains(query)));
            }
            else
            {
                return View(db.categorias.ToList());
            }
        }

        

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        
        public ActionResult Create(Categoria objeto)
        {
            try
            {
                db.categorias.Add(objeto);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // GET: CategoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriaController/Edit/5
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

        // GET: CategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaController/Delete/5
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
