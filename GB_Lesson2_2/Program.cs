using System;

namespace GB_Lesson2_2
{
    class Program
    {
        enum Months
        {
            Январь,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            var number = int.Parse(Console.ReadLine());
            if (number <= 12 && number >= 1)
            {
                Months month = (Months)number - 1;
                Console.WriteLine(month);
            }
            else
                Console.WriteLine("Нет такого месяца");
        }
    }
}
