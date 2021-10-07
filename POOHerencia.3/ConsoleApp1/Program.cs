using System;
using BLL;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var aparato = new AparatoElectrodomestico();
            aparato.Interruptor = (12);
            aparato.CableElectrico = (130);
            
            Console.WriteLine("El aparato electronico  cuenta con un  interectuctor  de {0} voltios y cuenta con un cable de \t{1}cm   ",
            
            aparato.Interruptor,
            aparato.CableElectrico
            
            );
            var television = new Television();
            television.BotonDeCanales = (15);
            television.BotonDeCanales = (140);

            Console.WriteLine("El aparato electronico cuenta con un control  de {0}botones y cuenta con \t{1}canales   ",

            television.BotonDeVolumen,
            television.BotonDeCanales

            );

            var lavadora= new Lavadora();
            lavadora.CapacidadDeCarga = (150);
           lavadora.PerillaDeCiclosDeLavado = (3);

            Console.WriteLine("la lavadora tiene una capacidad de carga de  de {0}la perrilla  es de  \t{1} ciclos   ",

            lavadora.CapacidadDeCarga,
            lavadora.PerillaDeCiclosDeLavado
             
        

            );
            Console.ReadKey();


        }
    }
}
