using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebPublicacion.Controllers
{
    public class PublicacionController : Controller
    {
        Libro libro1 = new Libro();///coleccion de libros o una lista
        CD cd1 = new CD();///coleccion de CD DE Tal manera
        bool CD;

        List<Libro> libros;
        List<CD> cds;

        public PublicacionController()
        {
            libros = new List<Libro>();
            cds = new List<CD>();
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CapturarDatos(int intTipo, string strTitulo ,double dblPrecio,int intNumeropaginas, int intTiempoReproduccion)//recibe los parametros
          {
            //Tipo == 1 : Libro
            //Tipo == 2 : CD
            if (intTipo==1)
            {
                libro1 = new Libro(strTitulo, dblPrecio, intNumeropaginas);
                libros.Add(libro1);
                CD = false;
            }
            if (intTipo == 2)
            {
                cd1 = new CD(strTitulo, dblPrecio, intTiempoReproduccion); ;
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
