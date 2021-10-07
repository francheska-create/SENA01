using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Persona
    {

        private DateTime dateTime;

        public DateTime FechaNacimento
        {
            get { return dateTime; }
            set { dateTime = value; }
        }



        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int CalcularEdad()
        {
            int intEdad;
            TimeSpan intervalo;
            intervalo = DateTime.Now - this.FechaNacimento;
            intEdad = (int)(intervalo.Days / 365.25);
            return (intEdad);

        }
    }
}
