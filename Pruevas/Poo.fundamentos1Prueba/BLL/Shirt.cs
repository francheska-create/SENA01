using System;

namespace BLL
{
    public class Shirt
    {
        public Guid ShirtId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public Color Color { get; set; }




        public static Guid CalculateShirId()
        {
            return Guid.NewGuid();
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Id de la camisa {0}, precio {1}, descripcion {2}, Talla {3} y color {4}",
                ShirtId, Price, Description, Size, Color);
    
        }
    }
}
