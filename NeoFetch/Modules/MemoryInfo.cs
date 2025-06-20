using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace NeoFetch.Modules
{
    
    public class MemoryInfo: ISystemModule
    {
        public string Name => "Memory";
        public string GetInfo()
        {
            var memoryInfo=GC.GetGCMemoryInfo();
            double ram = memoryInfo.TotalAvailableMemoryBytes/(1024.0*1024.0*1024.0);
            return $"{ram.ToString("0.00")} GB";
        }
    }
}
