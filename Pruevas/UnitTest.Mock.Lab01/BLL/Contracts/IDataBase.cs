﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IDataBase
    {
       public double GetTaxPercentagetByPersonId(int id);
    }
}
