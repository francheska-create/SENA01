using System;
using BLL;

namespace UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceOrientation serviceOrientation = new ServiceOrientation();
            
            var direction = Direction.Right;
            Console.WriteLine($"Map view direction is {direction}");
            Console.WriteLine($"Cardinal orientation is {serviceOrientation.ToOrientation(direction)}");
            Console.ReadKey();
        }
    }
}