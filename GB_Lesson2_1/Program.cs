using System;

namespace GB_Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру: ");
            var minTemperature = double.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру: ");
            var maxTemperature = double.Parse(Console.ReadLine());
            Console.WriteLine($"Среднесуточная термпература {(maxTemperature+minTemperature)/2}С");
        }
    }
}
