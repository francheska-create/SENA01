using BLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Database : IDataBase
    {
        double GetTaxPercentagetByPersonId(int id)
        {
            return 0;
        }

        double IDataBase.GetTaxPercentagetByPersonId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
