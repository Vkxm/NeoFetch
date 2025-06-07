using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoFetch.Modules
{
    public class CpuInfo : ISystemModule
    {
        public string Name => "CPU";

        public string GetInfo()
        {
            return Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER") ?? "Unknown";
        }
    }

}
