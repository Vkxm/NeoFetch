using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoFetch.Modules
{
    public class DiskInfo: ISystemModule
    {
        public string Name => "Disk";
        public string GetInfo()
        {
            var driveC= new DriveInfo("C");

            return $"{driveC.TotalSize / (1024 * 1024 * 1024)} GB";
        }
    }
}
