using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Estudiante : Persona
    {
        private int Grado;
        public int grado
        {
            get { return Grado; }
            set { Grado = value; }

        }
        private int Grupo;
        public int grupo
        {
            get { return Grupo; }
            set { Grupo = value; }

        }


        public static void estudiar()
        {
            Console.WriteLine("estudiar");
        }
    }
}