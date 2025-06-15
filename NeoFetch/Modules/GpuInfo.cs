using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace NeoFetch.Modules
{
    public class GpuInfo : ISystemModule
    {
        public string Name => "GPU";
        private string _query = "SELECT Name FROM Win32_VideoController";
        public string GetInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(_query);
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Name"].ToString(); 
            }
            return "Unknown";
        }
    }
}
