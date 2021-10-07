using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RecibirFecha( string Nombre, DateTime FechaNacimiento)
        {
            Persona objPersona = new Persona();
            objPersona.Nombre = Nombre;
            objPersona.FechaNacimento = FechaNacimiento;
            var edad =objPersona.CalcularEdad();
            return Json(edad);

        }
    }
}
