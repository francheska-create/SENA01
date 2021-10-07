using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public abstract  class Persona
  {
        private int _nombre;

        public int Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
         
         private DateTime fechadenacimientodateTime;

        public DateTime FechadenacimientodateTime
        {
            get { return fechadenacimientodateTime; }
            set { fechadenacimientodateTime = value; }
        }

        public abstract void comer();


        public int CalcularEdad()
        {
            int intEdad;
            TimeSpan intervalo;
            intervalo = DateTime.Now - this.FechadenacimientodateTime;
            intEdad = (int)(intervalo.Days / 356.25);
            return (intEdad);


        }
  }
}
