using BLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    

    public class TaxCalculator
    {
        Database objDataBase = new Database();
        private readonly IDataBase _database;

        public TaxCalculator(IDataBase database)
        {
            _database = database;
        }
        public double CalculateTotalValueForPerson(double amount, int id)
        {
            var tax = _database.GetTaxPercentagetByPersonId(id);
            return Math.Round(amount * (1 + tax), 2);
        }
    }
}
