using System;
using System.Collections.Generic;
using BLL;

namespace pl01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new(year: 1976, month: 9, day: 17);
            int edad = UtilidadFecha.CalcularEdad(date);
            Console.WriteLine("Resultado1#:clase estatica");
            Console.WriteLine("la edad de la persona es: {0} \n",edad);
            

            Shirt myShirt = new();
            myShirt.ShirtId = Shirt.CalculateShirId();
            myShirt.Price = 100000;
            myShirt.Description = "Camisa 100% algodon";
            myShirt.Size = "M";
            myShirt.Color= Color.blue;

            Shirt yourShirt = new()
            {
                ShirtId = Shirt.CalculateShirId(),
                Price = 200000,
                Description = "Camisa 80% algodon. 20% hilo",
                Size = "l",
                Color = Color.red
            };

            List<Shirt> colCamisas = new()
            {
                myShirt,
                yourShirt
            };

            Console.WriteLine("Resultado #2: Clase concreta");
            Console.WriteLine("Coleccion de camisas: ");
            foreach(var item in colCamisas)
            {
                item.DisplayInformation();
            }

            Console.WriteLine("\nResultado #3: Combinacion de una clase concreta y una estatica");
            Persona person = new Persona()
            {
                Nombres = "Francheska",
                Apellidos = "Lozano",
                Correo = "yflavidaesbella@gmail.com",
                Edad = UtilidadFecha.CalcularEdad(new DateTime(1995, 11, 07))
            };
            Console.WriteLine(person.ToString());
            Console.ReadKey();
        }
    }
}
