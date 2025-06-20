using NeoFetch.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
namespace NeoFetch.Printing
{
    public class Renderer
    {
        public static void Render(List<ISystemModule> modules)
        {
            var table = new Table();

            table.AddColumn("Title");
            table.AddColumn("Description");

            foreach (var module in modules)
            {
                table.AddRow(module.Name, module.GetInfo());

            }
            AnsiConsole.WriteLine($"{Environment.UserName}@{Environment.MachineName}");

            AnsiConsole.Write(table);
        }
    }

}
