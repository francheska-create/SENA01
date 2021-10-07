using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class PublicacionController : Controller
    {
        Libro libro1 = new Libro();///coleccion de libros o una lista
        CD cd1 = new CD();///coleccion de CD DE Tal manera
        bool CD;

        /* */

        List<Libro> libros;
        List<CD> cds;


        public PublicacionController()
        {
            libros = new List<Libro>();
            cds = new List<CD>();
        }



        /* */


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CapturarDatos(int tipo, string Titulo ,double Precio,int Numeropaginas, int tiempoReproduccion)//recibe los parametros
          {
            //Tipo == 1 : Libro
            //Tipo == 2 : CD
            if (tipo==1)
            {
                libro1 = new Libro(Titulo, Precio, Numeropaginas);
                libros.Add(libro1);


                CD = false;
            }
            if (tipo == 2)
            {
                cd1 = new CD(Titulo, Precio, tiempoReproduccion);
                cds.Add(cd1);
                CD = true;
            }
            return MostrarDatos();

        }
        [HttpPost]
        public JsonResult MostrarDatos()
        {
            if(CD)
            {
                return Json(cds); 
            }
            else
            {
                return Json(libros);
            }
            
           

        }
    }
}
