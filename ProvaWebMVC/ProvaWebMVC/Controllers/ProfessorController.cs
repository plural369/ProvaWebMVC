using ProvaWebMVC.Context;
using ProvaWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaWebMVC.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly Contexto db = new Contexto();
        // GET: Professor
        public ActionResult Index()
        {
            return View(db.Professor.ToList());
        }

        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfessorModel professor)
        {
            if (ModelState.IsValid)
            {
                db.Professor.Add(professor);
                db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}