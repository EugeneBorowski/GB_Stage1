using System;

namespace GB_Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var first = int.Parse(Console.ReadLine());
            if(first%2==0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число не четное");
        }
    }
}
