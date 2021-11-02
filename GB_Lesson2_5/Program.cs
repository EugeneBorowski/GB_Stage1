using System;
using System.Threading.Channels;

namespace GB_Lesson2_5
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
            Console.Write("Введите минимальную температуру: ");
            var minTemperature = double.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру: ");
            var maxTemperature = double.Parse(Console.ReadLine());
            var midTemperature = (maxTemperature + minTemperature) / 2;
            Console.Write("Введите порядковый номер месяца: ");
            var number = int.Parse(Console.ReadLine());

            if (number <= 12 && number >= 1)
            {
                Months month = (Months)number - 1;
                Console.WriteLine(month);
                if((month == Months.Декабрь || month == Months.Январь || month == Months.Февраль) && midTemperature>0)
                    Console.WriteLine("Дождливая зима");
            }
            else
                Console.WriteLine("Нет такого месяца");
        }
    }
}
