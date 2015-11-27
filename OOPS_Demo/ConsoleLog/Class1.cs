using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLog
{
    public class ConsoleLog
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        internal void LogConsole(string message)
        {
            Console.WriteLine(DateTime.Now+" "+message);
        }
    }
}
