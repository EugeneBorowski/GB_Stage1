using System;

namespace GB_Lesson4_3
{
    class Program
    {
        enum month
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void GetMonthByNumber()
        {
            int.TryParse(Console.ReadLine(), out var monthNumber);
            while (monthNumber > 12 || monthNumber < 1)
            {
                Console.Clear();
                Console.WriteLine("Ошибка: введите число от 1 до 12 ");
                Console.WriteLine("Введите номер месяца: ");
                monthNumber = int.Parse(Console.ReadLine());
            }

            var curmonth = GetMonth(monthNumber);
            Console.WriteLine(curmonth);
        }

        static month GetMonth(int monthNumber)
        {
            if (monthNumber >= 3 && monthNumber <= 5)
            {
                return month.Spring;
            }
            else if (monthNumber >= 6 && monthNumber <= 8)
            {
                return month.Summer;
            }
            else if (monthNumber >= 9 && monthNumber <= 11)
            {
                return month.Autumn;
            }
            else return month.Winter;
        }

        public static void Main()
        {
            Console.WriteLine("Введите номер месяца: ");
            GetMonthByNumber();
        }
    }
}
