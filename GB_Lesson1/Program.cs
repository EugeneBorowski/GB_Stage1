using System;

namespace GB_Lesson1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите свое имя:");
            var userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now}");
        }
    }
}
