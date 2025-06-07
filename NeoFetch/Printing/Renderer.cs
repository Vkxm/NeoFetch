using NeoFetch.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoFetch.Printing
{
    public class Renderer
    {
        public static void Render(List<ISystemModule> modules)
        {
            foreach (var module in modules)
            {
                Console.WriteLine($"{module.Name,-10}: {module.GetInfo()}");
            }
        }
    }

}
