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
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                double ramKB = Convert.ToDouble(obj["TotalVisibleMemorySize"]);
                double ramGB = ramKB / (1024 * 1024); // Convert KB to GB
                return $"{ramGB:0.00} GB"; // "32.00 GB"
            }
            return "Unknown";
        }
    }
}
