using System;
using BLL;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable automovil
            var Automovil = new Automovil();

            
            Automovil.CaballosFuerza = 80;
            Automovil.CantidadPuertas = 4;
            Automovil.NumeroRin = 4;

            Console.WriteLine("Los caballos de fuerza del automovil son: {0}, tiene: \t {1} puertas y {2} Rines.",
            Automovil.CaballosFuerza = 80,
            Automovil.CantidadPuertas = 4,
            Automovil.NumeroRin = 4
            );

            Automovil.Arrancar();
            Automovil.Acelerar(30);
            Automovil.Detener();

            // Variable bicicleta
            var Bicicleta = new Bicicleta();

            
            Bicicleta.CaballosFuerza = 0;
            Bicicleta.CantidadRuedas = 2;
            Bicicleta.NumeroRin = 2;

            Console.WriteLine("Los caballos de fuerza de la bicicleta son: {0} , tiene: \t {1} ruedas y {2} rines.",
            Bicicleta.CaballosFuerza = 0,
            Bicicleta.CantidadRuedas = 2,
            Bicicleta.NumeroRin = 2
            );

            Bicicleta.Arrancar();
            Bicicleta.Acelerar(15);
            Bicicleta.Detener();


            //variable avion
            var Avion = new Avion();

            Avion.CaballosFuerza = 400;
            Avion.MetrosSobreMar = 1200;
            Avion.NumeroTurbinas = 2;

            Console.WriteLine("Los caballos de fuerza del avion son: {0}, su altitud es: \t {1} msnm y tiene {2} turbinas",
            Avion.CaballosFuerza,
            Avion.MetrosSobreMar,
            Avion.NumeroTurbinas
            );

            Avion.Arrancar();
            Avion.Elevacion(1200);
            Avion.Detener();

            //variable helicoptero

            var Helicoptero = new Helicoptero();

            Helicoptero.CaballosFuerza = 200;
            Helicoptero.MetrosSobreMar = 400;
            Helicoptero.Eleva = 100;

            Console.WriteLine("Los caballos de fuerza del Helicoptero son: {0}, su altitud es: \t {1} msnm y se eleva a {2} metros",
            Helicoptero.CaballosFuerza = 200,
            Helicoptero.MetrosSobreMar = 400,
            Helicoptero.Eleva = 100
            );

            Helicoptero.Arrancar();
            Helicoptero.Elevacion(400);
            Helicoptero.Detener();

            //FIN

            Console.ReadKey();
        }
    }
}
