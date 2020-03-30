using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsole console = new ReaLConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
