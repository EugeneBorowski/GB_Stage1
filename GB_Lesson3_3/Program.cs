using System;

namespace GB_Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var str = Console.ReadLine();
            var tempstr = str.ToCharArray();
            Array.Reverse(tempstr);
            var reverseString = new string(tempstr);
            Console.WriteLine("Реверсивная строка: " + reverseString);
        }
    }
}
