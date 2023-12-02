using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystemSRPAfter.Loggers
{
    public class ConsoleLogger
    {
        public static void WriteInfo(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public static void WriteError(string message, Exception ex) 
        {
            Console.WriteLine($"Error: {message}; {ex}");
        }
    }
}
