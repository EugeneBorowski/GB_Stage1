using System;
using System.IO;

namespace GB_Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "startup.txt";
            File.AppendAllText(path, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.fff") +"\n");
            Console.WriteLine($"Сохранено в файл {Directory.GetCurrentDirectory()}\\{path}");
        }
    }
}
