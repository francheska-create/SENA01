﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple.Entities
{
     public class SchedulerTask
    {
        public int TaskId { get; set; }
        public string Content{ get; set; }
        public DateTime ExcuteOn { get; set; }
    }
}
