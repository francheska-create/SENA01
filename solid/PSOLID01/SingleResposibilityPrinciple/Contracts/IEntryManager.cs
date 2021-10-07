﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple.Contracts
{
   public interface IEntryManager<T>
    {

        void AddEntry(T entry);
        void RemoveEntryAt(int index);
    }
}
