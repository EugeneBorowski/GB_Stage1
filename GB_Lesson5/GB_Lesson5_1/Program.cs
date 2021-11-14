using System;
using System.IO;

namespace GB_Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "file.txt";
            Console.Write("Введите произвольную строку: ");
            var input = Console.ReadLine();
            File.WriteAllText(path,input);
            Console.WriteLine($"Сохранено в файл {Directory.GetCurrentDirectory()}\\{path}");
            Console.ReadLine();
        }
    }
}
