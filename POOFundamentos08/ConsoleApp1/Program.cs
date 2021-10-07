using System;
using BLL;
namespace ConsoleApp1
{
    class Program
    {
        public static object vegetariano { get; private set; }

        static void Main(string[] args)
        {
            Diabetico diabetico=new Diabetico();
            
            Console.WriteLine("Diabetico");
            diabetico.comer();
            Vegetariano vegetariano = new Vegetariano();
            Console.WriteLine("vegetariano:");
            vegetariano.comer();
            Console.ReadKey();
        }
    }
}
