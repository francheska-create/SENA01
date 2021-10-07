using BLL;
using System;
using System.Collections.Generic;


namespace POOFundamentos03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var automovil = new Automovil();
            automovil.Caballosfuerza = 20;
            automovil.cantidadpuertas = 5;
           
            Console.WriteLine("Los caballos de Fuerza del vehiculo son{0} y la cantidad de puertas es\t{1}",
            automovil.Caballosfuerza,
            automovil.cantidadpuertas 
            );
             automovil.Arrancar();
              automovil.Acelerar(30);
              automovil.Detener();
            var palaMecanica= new Palamecanica();
             palaMecanica.Caballosfuerza = 300;
             palaMecanica.pesomaximolevante =2500 ;
           
            Console.WriteLine("Los caballos de Fuerza del la pala mecanicason:{0} y la cantidad de puertas es\t{1}",
            palaMecanica.Caballosfuerza,
            palaMecanica.pesomaximolevante
            );
            palaMecanica.Arrancar();
            palaMecanica.Moverpala("derecha");
            palaMecanica.Detener();

            Console.ReadKey();

        }
    }
}
