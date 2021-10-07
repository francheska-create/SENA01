using BLL;
using System;
using System.Collections.Generic;


namespace POOFundamentos03
{
    class Program
    {
        static void Main(string[] args)
        {

            var persona = new Persona();
            persona.name =(3);
            persona.domicilio=(5);
            persona.horario =(8);

            Console.WriteLine("las personas son {0} y EL Horario es de\t{1}, la cantidad de domicio es de\t{2}   ",
            persona.name,
            persona.domicilio,
            persona.horario
              );
            var empleado = new Empleado();
            empleado.jefe = (9);
            empleado.name = (1);
            empleado.domicilio = (5);
            empleado.horario = (8);


            Console.WriteLine("Hay {0} Jefes con solo \t{1} nombre, la cantidad de domicios,que pidieron son de\t{2} Domicilios el horario es de\t{3} horas",
            empleado.jefe,
            empleado.name,
            empleado.domicilio,
            empleado.horario
            );
            var estudiante = new Estudiante();
            estudiante.grado = (2141041);
            estudiante.name = (1);
            estudiante.domicilio = (5);
            estudiante.horario = (8);
            estudiante.grupo = (2);

            Console.WriteLine("Estudiante del grado {0} con solo \t{1} nombre, la cantidad de domicios,que pidieron son de\t{2} Domicilios el horario es de\t{3} horas, del grupo \t{3}  ",
            estudiante.grado,
            estudiante.name,
            estudiante.domicilio,
            estudiante.horario
            );

            var adimistrador = new Administrador();

            adimistrador.jefe= (1);
            adimistrador.Puesto = (5);
            adimistrador.horario = (8);


            Console.WriteLine("El admisitrador tiene {0} Jefe y un \t{1} Domicilios el horario es de\t{2} horas",
            adimistrador.jefe,
            adimistrador.Puesto,
            adimistrador.horario
           
            );

            var profesor = new Profesor();

            profesor.jefe = (1);
            profesor.Carrera = (1);
            profesor.horario = (8);


            Console.WriteLine("El profesor tiene {0} Jefe y una carrera \t{1}  el horario de trabajo es de\t{2} horas",
           profesor.jefe,
           profesor.Carrera,
           profesor.horario);

            Console.ReadKey();
        }
    }
}
