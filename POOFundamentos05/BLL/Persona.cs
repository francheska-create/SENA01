using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Persona {


        private DateTime dateTime;

        public DateTime FechaNacimento
        {
            get { return dateTime; }
            set { dateTime = value; }
        }



        private int nombre;

        public int Nombre
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


 
       
      



    

