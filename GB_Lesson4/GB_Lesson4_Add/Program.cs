using System;

namespace GB_Lesson4_Fib
{
    class Program
    {
        static int GetFibonacci(int n)
        {
            if (n == 0 || n == 1) return n;
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write($"Введите число: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число фибоначчи: {GetFibonacci(n)}");
        }
    }
}
