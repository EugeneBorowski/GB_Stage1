using System;
using System.IO;

namespace GB_Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "file.bin";
            Console.Write("Введите произвольный набор чисел через пробел (0...255): ");
            var byteString = Console.ReadLine();
            string[] subs = byteString.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var byteArray = new byte[subs.Length];
            for (var i=0; i<=byteArray.Length-1; i++)
                byteArray[i] = byte.Parse(subs[i]);
            File.WriteAllBytes(path, byteArray);
            Console.WriteLine($"Сохранено в файл {Directory.GetCurrentDirectory()}\\{path}");
            Console.ReadLine();
        }
    }
}
