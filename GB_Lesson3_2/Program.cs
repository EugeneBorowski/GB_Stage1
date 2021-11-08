using System;

namespace GB_Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new String[5, 2];
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            for (int j = 0; j < phoneBook.GetLength(1); j++)
            {
                if (j == 0)
                    Console.WriteLine("Введите ФИО: ");
                else
                    Console.WriteLine("Введите телефон/E-mail: ");
                phoneBook[i, j] = Console.ReadLine();
            }

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.WriteLine("--------------------------------");
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    if (j == 0)
                        Console.WriteLine("ФИО: " + phoneBook[i, j]);
                    else
                        Console.WriteLine("Контакт: " + phoneBook[i, j]);
                }
            }
        }
    }
}
