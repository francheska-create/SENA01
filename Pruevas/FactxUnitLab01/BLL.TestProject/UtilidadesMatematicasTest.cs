using BLL;
using System;
using Xunit;

namespace BLL.TestProject
{
    public class UtilidadesMatematicasTest
    {
        [Fact]
        public void SumarTest()
        {
            ///Arange
            double a = 10;
            double b = 20;
            double expected = 30;

            ///Act

            var result = UtilidadMatematica.Sumar(a, b);

            ///Asser
            Assert.Equal(expected, result);

        }
        [Fact]
        public void RestarTest()
        {
            ///Arange
            double a = 20;
            double b = 10;
            double expected =10;

            ///Act

            var result = UtilidadMatematica.Restar(a, b);

            ///Asser
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(200, 20, 10)]
        [InlineData(200, -20, -10)]
        [InlineData(-200,20,-10)]
        [InlineData(0,0,-10)]
        public void MultiplicarTest(double expected,double a, double b)
        {
         

            ///Act

            var result = UtilidadMatematica.Multiplicar(a, b);

            ///Asser
            Assert.Equal(expected, result);


        }
        //[Fact]
       /// public void MultiplicarTest02()
        //{
            ///Arange
         //   double a = -20;
         //   double b = -10;
            ///double expected =-200;

            ///Act

           // var result = UtilidadMatematica.Multiplicar(a, b);

            ///Asser
          ///  Assert.Equal(expected, result);


      // }
      ///  [Fact]
       /// public void MultiplicarTest03()
      ///  {
            ///Arange
           /// double a = +20;
          ////  double b = -10;
          ///  double expected = 200;

            ///Act

            ///var result = UtilidadMatematica.Multiplicar(a, b);

            ///Asser
           //// Assert.Equal(expected, result);


        ////}
        /////[Fact]
       //// public void MultiplicarTest04()
      ///  {
            ///Arange
         ////   double a = 0;
         ///   double b = 10;
           /// double expected =0;

            ///Act

           /// var result = UtilidadMatematica.Multiplicar(a, b);

            ///Asser
           //// Assert.Equal(expected, result);


       /// }
        [Fact]
        public void DividirTest()
        {
            ///Arange
            double a = 20;
            double b = 10;
            double expected =2;

            ///Act

            var result = UtilidadMatematica.Dividir(a, b);

            ///Asser
            Assert.Equal(expected, result);


        }
        [Fact]
        public void DividirByCeroTest()
        {
            ///Arange
            double a = 20;
            double b = 0;
            var exception = (Exception)Assert.Throws<DivideByZeroException>(() =>

            {
                ///Act

                var result = UtilidadMatematica.Dividir(a, b);
                Assert.IsType<double>(result);

            });
         ///Asser
            Assert.IsType<DivideByZeroException>(exception);


        }
    }
}
