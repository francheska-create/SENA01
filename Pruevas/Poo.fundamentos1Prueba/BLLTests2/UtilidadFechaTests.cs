using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  BLL.Tests
{
    [TestClass()]
    public class UtilidadFechaTests
    {
        [TestMethod()]
        public void CalcularEdadFMenorHoyTest()
        {
            ///arange
            UtilidadFecha utilidadFecha = new UtilidadFecha();
            DateTime edad = new DateTime(1995, 11, 07);
            int edadCalculada = utilidadFecha.CalcularEdad(edad);

            Assert.AreEqual(44,edadCalculada );
        }
        
        [TestMethod()]
        public void CalcularEdadFNsuperiorHoyTest()
        {
            ///arange
            UtilidadFecha utilidadFecha = new UtilidadFecha();
            DateTime edad = new DateTime(2076, 09, 17);
            
            //assert
            Assert.ThrowsException<ArgumentException>(()=>utilidadFecha.CalcularEdad(edad));
        }

        [TestMethod()]
        public void CalcularEdadFMayorIgualHoyTest()
        {
            ///arange
            UtilidadFecha utilidadFecha = new UtilidadFecha();
            DateTime edad = DateTime.MaxValue;

            //assert
            Assert.ThrowsException<ArgumentException>(() => utilidadFecha.CalcularEdad(edad));
        }

        [TestMethod()]
        public void CalcularEdadFNMenorIgualHoyTest()
        {
            ///arange
            UtilidadFecha utilidadFecha = new UtilidadFecha();
            DateTime edad = DateTime.MaxValue;

            //assert
            Assert.ThrowsException<ArgumentException>(() => utilidadFecha.CalcularEdad(edad));
        }

    }
}