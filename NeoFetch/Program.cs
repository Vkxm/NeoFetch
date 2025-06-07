using NeoFetch.Modules;
using NeoFetch.Printing;
using Spectre.Console;
class Program
{
    public static void Main()
    {
        var modules = new List<ISystemModule>
        {
            new CpuInfo(),
            new OsInfo()
        };

        Renderer.Render(modules);
    }
}