using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace NeoFetch.Modules
{
    public class CpuInfo : ISystemModule
    {
        public string Name => "CPU";

        public string GetInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Name"].ToString();
            }
            return "Unknown";
        }
       
    }

}
