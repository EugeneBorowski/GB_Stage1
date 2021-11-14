using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var processes = Process.GetProcessesByName("firefox.exe");
            foreach (var process in processes)
            {
                Console.WriteLine($"{nameof(Process.ProcessName)}: {process.ProcessName}, {nameof(process.Id)}: {process.Id}");
            }
        }
    }
}
