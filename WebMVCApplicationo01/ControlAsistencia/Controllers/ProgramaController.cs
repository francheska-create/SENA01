using ControlAsistencia.Data;
using ControlAsistencia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlAsistencia.Controllers
{
    public class ProgramaController : Controller
        
    {
        private readonly ApplicationDbContext _context;
        public ProgramaController(ApplicationDbContext context)
        {
            this._context = context;
        }
        // GET: ProgramaController
        [HttpGet]
        public ActionResult Index()
        {
            return View(_context.programa.ToList());
        }

        // GET: ProgramaController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {

                return NotFound();//Error 404

            }
            var programa = _context.programa.FirstOrDefault(programa => programa.ProgramaId == id);

            if (programa == null)
            {

                return NotFound();//Error 404

            }


            return View(programa);

        }

        // GET: ProgramaController/Create
        [HttpGet]//Renderizar la vista
        public ActionResult Create()
        {
            return View();
        }

        //// POST: ProgramaController/Create
        [HttpPost]//ingreso los datos ala base da datos
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Progrmaid,Nombre,Version,Codigo")]Programa programa)
        {
           if(ModelState.IsValid)
           {
                programa.Estado = true;
                _context.Add(programa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
          
           }
            return View(programa);
        }

        //// GET: ProgramaController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            if(id == null)
            {

                return NotFound();//Error 404

            }
            var programa = _context.programa.Find(id);

            if (programa == null)
            {

                return NotFound();//Error 404

            }


            return View(programa);

        }

        //// POST: ProgramaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,[Bind("ProgramaId,Nombre,Version,Codigo")] Programa programa)
        {
            if (id!=programa.ProgramaId)
            {

                return NotFound();//Error 404

            }
            if (ModelState.IsValid)
            {

                try
                {
                    programa.Estado = true;
                    _context.Update(programa);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramaExists( programa.ProgramaId))
                    {

                        return NotFound();//Error 404

                    }
                    else {
                        throw;
                    
                    }
                   
                }
                return RedirectToAction(nameof(Index));
            }
            
            return View(programa);
        }

        private bool ProgramaExists(int programaId)
        {
            throw new NotImplementedException();
        }

        //// GET: ProgramaController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {

                return NotFound();//Error 404

            }
            var programa = _context.programa.FirstOrDefault(programa=>programa.ProgramaId==id);

            if (programa == null)
            {

                return NotFound();//Error 404

            }


            return View(programa);

        }
        ///POST: ProgramaController/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, IFormCollection collection)
        {
            var programa = _context.programa.Find(id);
            programa.Estado = false;
            _context.Update(programa);
            _context.SaveChanges();
                return RedirectToAction(nameof(Index));
        }
        
    }
}
