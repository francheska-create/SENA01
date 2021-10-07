using System;
using BLL;

namespace UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceOrientation = new ServiceOrientation();
            var direction = Direction.Right;
            Console.WriteLine($"Map view direction is {direction}");
            Console.WriteLine($"Cardinal orientation is {ServiceOrientation.ToOrientation(direction)}");
            Console.ReadKey();
        }
    }
}