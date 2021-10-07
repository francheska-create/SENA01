using ControlAsistencia.Data;
using ControlAsistencia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace ControlAsistencia.Controllers
{
    public class ProgramaController : Controller
        
    {
        private readonly ApplicationDbContext _context;
        public string draw = "";
        public string start = "";
        public string  length= "";
        public string stortColumn = "";
        public string stortColumnDir = "";
        public string searchValue = "";
        public int pagaSize, skip, recordsTotal; 




        public ProgramaController(ApplicationDbContext context)
        {
            this._context = context;
        }
        // GET: ProgramaController
        [HttpGet]
        public ActionResult Index()
        {
            return View();// quitar la responsabilidad de llenar DataTables
        }
        /// quitar responsabilida ala base de datos
        [HttpGet]
        public IActionResult loadDatatable()
        {
            return Json(new { data =_context.programa.ToList().Where(programa => programa.Estado == true) });
        
        }
        //// GET: ProgramaController/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var programaFronDB = _context.programa.Find(id);
            if (programaFronDB == null)
            {
                return Json(new { sucesss = false, message = "Error borrando el programa de formacion." });
            }
            _context.programa.Remove(programaFronDB);
            _context.SaveChanges();
            return Json(new { success = true, message = "categoria Borrada Correctamente" });
        }

        ///post json ///
       [HttpPost]
       public IActionResult Json()
        {
               ////logistica de dataTable//
            List<Programa> Ist =new List<Programa>();
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            var start= Request.Form["draw"].FirstOrDefault();
            var length= Request.Form["draw"].FirstOrDefault();
            var stortColumn= Request.Form["Colunm["+Request.Form["order[0][column]"].FirstOrDefault()+"][name]"].FirstOrDefault();
            var stortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue= Request.Form["search[value]"].FirstOrDefault();

            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skit = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal =0;

            using (_context)
            {

                IQueryable<Programa> query = (from p in _context.programa
                  select p).Where(e =>e.Estado == true);

                if (searchValue != "")
                {
                    query=query.Where(p=>p.Nombre.Contains(searchValue));
                }
                if(!(string.IsNullOrEmpty(stortColumn)&& string.IsNullOrEmpty(stortColumnDirection)))
                {
                    query = query.OrderBy(stortColumn + " " + stortColumnDirection);


                }
                recordsTotal = query.Count();
                Ist = query.Skip(skit).Take(pageSize).ToList();
              
            }

            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = Ist });
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
            return _context.programa.Any(e => e.ProgramaId==programaId);
        }

      

        //// GET: ProgramaController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    if (id == null)
        //    {

        //        return NotFound();//Error 404

        //    }
        //    var programa = _context.programa.FirstOrDefault(programa => programa.ProgramaId == id);

        //    if (programa == null)
        //    {

        //        return NotFound();//Error 404

        //    }


        //    return View(programa);

        //}
        ///POST: ProgramaController/Delete/5
        [HttpPost, ActionName("Delete")]
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
    
