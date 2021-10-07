using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;

namespace BLL
{
    public class Factura : Ifecha, IDesplegable
    {
        private int _intFolio;
        private string _strCliente;
        private double _dlbTotal;
        private DateTime _dtmFecha;

        public DateTime Fecha
        {
            get { return _dtmFecha; }
            set { _dtmFecha = value; }
        }


        public double Total
        {
            get { return _dlbTotal; }
            set { _dlbTotal = value; }
        }


        public string Cliente
        {
            get { return _strCliente; }
            set { _strCliente = value; }
        }


        public int Folio
        {
            get { return _intFolio; }
            set { _intFolio = value; }
        }
        DateTime Ifecha.fecha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FechaConLetra()
        {
            this.Fecha = DateTime.Now;
            return Fecha.ToString(format: "dddd, MMMM, yyyy");
        }
        string IDesplegable.MostrarDatos()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"Folio: {Folio} \t Fecha: {FechaConLetra()} \t Cliente:{Cliente} \t Total: {Total}";
        }


    }
}
