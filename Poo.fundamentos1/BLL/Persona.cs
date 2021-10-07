using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        private int edad;
        public int Edad
        {
            get { return edad; }

            set
            {
                if (value > 0 && value >= 110)
                {
                    edad = value;
                }
            }
        }
        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name must not be blank");
                }
                nombres = value;
            }
        }

        public string Apellidos
        
        { get {return apellidos; }
        
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name must not be blank");
                }
                apellidos = value;
            }
        }
    
        private string apellidos;

        private string correo;

        public string Correo 
        {
            get { return correo; }
            set { correo = value; }


        }

        public override string ToString() {
            return " Apellido" + "" + this.Apellidos + "," + "Nombres:" + this.Nombres + "." + "Correo" +
        this.Correo + "," + edad + "" + this.edad.ToString();
        }
   
            
}
   
}




       
     


