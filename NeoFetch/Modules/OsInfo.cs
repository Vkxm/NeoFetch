using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NeoFetch.Modules
{
    public class OsInfo : ISystemModule
    {
        public string Name => "OS";

        public string GetInfo()
        {
            string osDescription = RuntimeInformation.OSDescription;
            string osArch = RuntimeInformation.OSArchitecture.ToString();

            return $"{osDescription} ({osArch})";
        }
    }
}
