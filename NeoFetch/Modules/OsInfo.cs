using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace NeoFetch.Modules
{
    public class OsInfo : ISystemModule
    {
        public string Name => "OS";

        public string GetInfo()
        {
            
            string edition = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");

            foreach (ManagementObject os in searcher.Get())
            {
                edition = os["Caption"].ToString();
            }
            return edition;
        
        }

    }
}
