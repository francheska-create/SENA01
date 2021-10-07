using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Contracts;
using System.Text;
using System.Threading.Tasks;

namespace BLL.TestProject.ManualMock
{
    class MockDataBase : IDataBase
    {
        public double GetTaxPercentagetByPersonId(int id)
        {
            switch (id)
            {
                case 0:
                    return 0.12;
                case 1:
                    return 0.27;
                case 2:
                    return 0.04;
                default:
                    return 0.18;
            }
            
        }
    }
}
