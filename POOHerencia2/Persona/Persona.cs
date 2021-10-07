using System;

namespace BLL
{
    public class Persona
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String domicilio;

        public  String Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        private String horario;

        public String Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public static void Asistir()
        {
            Console.WriteLine("Asisitir");
        }



    }
}
