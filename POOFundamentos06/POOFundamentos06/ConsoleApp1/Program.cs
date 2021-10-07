using BLL;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro2 = new Libro();
            libro2.Titulo = "La Bruja";
            libro2.Precio =  2500;
            libro2.NumeroPaginas= 500;
            Libro libro1 = new Libro("pnl Programacion neurolinguistica", 1200,1234);
            Libro libro = new Libro("cien años de soledad", 150000, 1540);
            CD cd = new CD("Blanca Nieves",150000,1540);

            Console.WriteLine("{0}",libro.Titulo );
            Console.WriteLine("{0}",cd.Titulo);
            Console.ReadKey();
        }
    }
    
}
