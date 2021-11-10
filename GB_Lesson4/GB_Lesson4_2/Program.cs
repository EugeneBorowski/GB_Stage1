using System;

namespace GB_Lesson4_2
{
    class Program
    {
        static int GetNumbers(string str)
        {
            var result = 0;
            var tempstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                var currChar = str[i];
                while (i < str.Length && char.IsDigit(str[i]))
                {
                    tempstr += str[i];
                    i++;
                }

                if (i == str.Length || !char.IsDigit(str[i]))
                {
                    int.TryParse(tempstr,out var tempInt);
                    result += tempInt;
                    tempstr = "";
                }
            }
            return result;
        }

        public static void Main()
        {
            Console.Write("Введите числа через пробел: ");
            var str = Console.ReadLine();
            Console.WriteLine($"Сумма чисел: {GetNumbers(str)}");
            Console.ReadLine();
        }
    }
}
