using Microsoft.AspNetCore.Mvc;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFiguras.Controllers
{
    public class FiguraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult CalcularLado(double lado)
        { //lado coresponde al cuadrado
            Cuadrado objcuadrado = new Cuadrado();
            objcuadrado.Lado = lado;
            objcuadrado.CalcularArea();
            return Json(objcuadrado.ColsultarDatos());

        }
        [HttpGet]
        public JsonResult CalcularRadio(double radio)
        {// coresponde ala circunferencia
            Circunferencia objcircunferencia = new Circunferencia();
            objcircunferencia.Radio = radio;
            objcircunferencia.CalcularArea();
            return Json(objcircunferencia.ColsultarDatos());

        }

    }
}
