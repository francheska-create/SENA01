using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SingleResposibilityPrinciple.Contracts;

namespace SingleResposibilityPrinciple.Entities
{
    class FileServer
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> WorkReport)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath ?? throw new ArgumentNullException(nameof(directoryPath)));

            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }
    }
}
