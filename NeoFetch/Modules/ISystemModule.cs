using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoFetch.Modules
{
    public interface ISystemModule
    {
        string Name { get; }
        string GetInfo();
    }

}
