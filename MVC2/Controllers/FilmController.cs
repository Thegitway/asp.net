using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class FilmController : Controller
    {
        private FilmContext dba = new FilmContext();

        // GET: Film
        public ActionResult Index()
        {
            return View(dba.Films.ToList());
        }
        //GET: Film
        public ActionResult Detials()
        {

            return null;
        }
        //POST: Film/Details
        public ActionResult Details(Int32 Id)
        {
            return View(dba.Films.Find(Id));
        }
        

        //POST: Film/Creates
        public ActionResult Create([Bind(Include = "Id,Titre,Realisateur")]
Film film)
        {
            if (ModelState.IsValid)
            {
                dba.Films.Add(film);
                dba.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Film film = dba.Films.Find(id);
            return View(film);
        }

 [HttpPost]
        public ActionResult Edit([Bind(Include =
"Id,Titre,Realisateur")] Film film)
        {
            if (ModelState.IsValid)
            {
                dba.Entry(film).State = EntityState.Modified;
                dba.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Film film = dba.Films.Find(id);
            return View(film);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Film film = dba.Films.Find(id);
            dba.Films.Remove(film);
            dba.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}