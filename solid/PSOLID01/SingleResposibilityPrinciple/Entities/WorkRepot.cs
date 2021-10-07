using SingleResposibilityPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple.Entities
{
    class WorkRepot:IEntryManager<WorkerReportEntry>
    {
        private readonly List<WorkerReportEntry> _entries;
        public WorkRepot()
        {
            _entries = new List<WorkerReportEntry>();

        }
         public void AddEntry(WorkerReportEntry entry)=>_entries.Add(entry);
        public void RemoveEntryAt(int Index) => _entries.RemoveAt(Index);
        public override string ToString()
        {
            return string.Join(Environment.NewLine,
            _entries.Select(x => $"Code: { x.ProjectCode}, Name:{x.ProjectName}, Hours:{x.SpentHourts}"));
        }

       

    }
}
