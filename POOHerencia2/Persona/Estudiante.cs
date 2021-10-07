using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Estudiante : Persona
    {
        private int grado;

        public int Grado
        {
            get { return grado; }
            set { grado = value; }
        }

        private String grupo;

        public String Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public static void Estudiar()
        {
            Console.WriteLine("Estudiar");
        }


    }
}
