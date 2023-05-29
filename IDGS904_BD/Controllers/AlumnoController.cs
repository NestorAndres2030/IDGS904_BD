using IDGS904_BD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_BD.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            using(AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                //select * from alumnos
                return View(dbAlumnos.Alumnos.ToList());
            }


            return View();
        }
        public ActionResult Details( int? id)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                Alumnos alumnos = dbAlumnos.Alumnos.Find(id);
                if(alumnos == null)
                {
                    return HttpNotFound();
                }
                return View(alumnos);
            }
        }
        public ActionResult Edit(int? id)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                Alumnos alumnos = dbAlumnos.Alumnos.Find(id);
                if (alumnos == null)
                {
                    return HttpNotFound();
                }
                return View(alumnos);
            }
        }
        public ActionResult Edit(int? id,Alumnos alum)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                if (ModelState.IsValid)
                {
                    dbAlumnos.Entry(alum).State= EntityState.Modified;
                    dbAlumnos.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(alum);
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Alumnos alum)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
               dbAlumnos.Alumnos.Add(alum);
                dbAlumnos.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}