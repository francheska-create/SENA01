using Microsoft.AspNetCore.Mvc;
using POOFundamento04WebApplication.Models.entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOFundamento04WebApplication.Controllers
{
    public class CircunferenciaController : Controller
    {
        public IActionResult Index()
        {
            return View();
            

        }

        [HttpPost]
        public JsonResult Area(double radio)
        {
           Circunferencia circunferencia= new Circunferencia();
            circunferencia.Radio =radio;
            var area = circunferencia.CalcularArea();
            return Json(area);

        }

        [HttpPost]
        public JsonResult Perimetro(double radio)
        {
            Circunferencia circunferencia = new Circunferencia();
            circunferencia.Radio = radio;
            var perimetro = circunferencia.CalcularPerimetro();
            return Json(perimetro);

        }

    }
}
