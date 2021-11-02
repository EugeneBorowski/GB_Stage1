using System;

namespace GB_Lessson2_6
{
    class Program
    {
        [Flags]
        enum dayOfWeek
        {
            Понедельник = 0b_0000_0001,
            Вторник = 0b_0000_0010,
            Среда = 0b_0000_0100,
            Четверг = 0b_0000_1000,
            Пятница = 0b_0001_0000,
            Суббота = 0b_0010_0000,
            Воскресенье = 0b_0100_0000
        }
        static void Main()
        {
            var office1 = (dayOfWeek) 30;
            var office2 = (dayOfWeek) 127;
            Console.WriteLine($"Время работы офиса 1: {office1}\n");
            Console.WriteLine($"Время работы офиса 2: {office2}");
        }
    }
}
