using NeoFetch.Modules;
using NeoFetch.Printing;
using Spectre.Console;
class Program
{
    public static void Main()
    {
        var modules = new List<ISystemModule>
        {

            new OsInfo(),
            new CpuInfo(),
            new MemoryInfo(),
            new GpuInfo()
        };

        Renderer.Render(modules);
    }
}