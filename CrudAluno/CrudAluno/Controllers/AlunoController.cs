using CrudAluno.Context;
using CrudAluno.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CrudAluno.Controllers
{
    public class AlunoController : Controller
    {
        private readonly Contexto db = new Contexto();
        // GET: Aluno
        public ActionResult Index()
        {
            return View(db.Alunos.ToList());
        }

        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(AlunoModel aluno)
        {
            if (ModelState.IsValid)
            {
                db.Alunos.Add(aluno);
                db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AlunoModel aluno = db.Alunos.Where(a => a.Id == id).FirstOrDefault();

            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AlunoModel aluno = db.Alunos.Where(a => a.Id == id).FirstOrDefault();

            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlunoModel aluno)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(aluno).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(aluno);
                }
            }
            return View(aluno);
        }
        public ActionResult Delete(int? id) 
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AlunoModel AlunoModel = db.Alunos.Find(id);

            if (AlunoModel == null)
            {
                return HttpNotFound();
            }

            db.Alunos.Remove(AlunoModel);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}