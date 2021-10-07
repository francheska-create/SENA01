using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;

namespace BLL
{
    public class Cheques : IFecha
    {
        public int anio()
        {
            return DateTime.Now.Day;

        }

        public int Dia()
        {
            return DateTime.Now.Month;

        }

        public int mes()
        {
            return DateTime.Now.Year;

        }

        public string mesconLetra()
        {
            return MonthName(Mes());
        }

        private int Mes()
        {
            throw new NotImplementedException();
        }

        public string MonthName(int month) 
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
         }
    } 
}
