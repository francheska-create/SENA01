using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;

namespace BLL
{
     public class CuentaBancaria:Ifecha,IDesplegable
    {
        private int Numero;
        private double Saldo;
        private DateTime FechaDeApertura;

        
        public int numero
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public double saldo
        {
            get { return Saldo; }
            set { Saldo = value; }

        }
        public DateTime fechadeapertura
        {
            get { return FechaDeApertura; }
            set { FechaDeApertura = value; }
        }

        public DateTime fecha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FechaConLetra()
        {
            throw new NotImplementedException();
        }

        string IDesplegable.MostrarDatos()
        {
            throw new NotImplementedException();
        }

        string IDesplegable.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
