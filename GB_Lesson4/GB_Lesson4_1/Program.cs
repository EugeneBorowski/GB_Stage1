using System;

namespace GB_Lesson4_1
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }

        public static void Main()
        {
            Console.WriteLine(GetFullName("Петр", "Васильев", "Андреевич"));
            Console.WriteLine(GetFullName("Иван", "Петров", "Васильевич"));
            Console.WriteLine(GetFullName("Андрей", "Смирнов", "Андреевич"));
            Console.WriteLine(GetFullName("Алексей", "Солдатов", "Петрович"));
        }
    }
}
