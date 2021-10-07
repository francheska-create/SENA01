using System;
using BLL;
using Contratos;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable All
namespace UI.ConsoleApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {   // Ideal: Bajo acoplamiento y alta cohesión.

            //Idea #3. Técnica de Inyección de dependencias e inversión de control. Cumplo con bajo acoplamiento y alta cohesión
            var services = new ServiceCollection();
            services.AddTransient<Ifecha, Factura>();
            var sp = services.BuildServiceProvider();
            var factura = sp.GetRequiredService<Ifecha>();

            var year = factura.FechaConLetra();
            var day = factura.fecha;

            



            Console.WriteLine($"Paguese la suma de US 5.000 a Jeff Preston Bezos, el {day}-{year}.");
            Console.ReadKey();
        }
       
    }
}