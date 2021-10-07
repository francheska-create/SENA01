using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Persona
    {
        private int Domicilio;
        public int domicilio
        {
            get { return Domicilio; }
            set { Domicilio = value; }

        }
        private int Name;
        public int name

        {
            get { return Name; }
            set {Name = value; }
        }
        private int Horario;
        public int horario
        {
            get { return Horario; }
            set { Horario = value; }
        }



        public static void Asistir()
        {
            Console.WriteLine("asitir");
        }
    }
}