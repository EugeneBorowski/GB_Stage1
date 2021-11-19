using System;
using System.Diagnostics;

namespace GB_Lesson6_1
{
    class Program
    {
        public static void KillById(int id)
        {
            try
            {
                Process processes = Process.GetProcessById(id);
                processes.Kill();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Процесс не найден");
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }

        }
        public static void KillByName(string name)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(name);
                foreach (var proc in processes)
                {
                    proc.Kill();
                }
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }

        }

        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("PID   | Process name");
            Console.WriteLine("======|============================");
            foreach (var e in processes)
                Console.WriteLine(string.Format("{0,5} | {1,-28}", e.Id, e.ProcessName));
            Console.WriteLine("===================================\n");
            Console.Write("Введите 1 для завершения процесса по id и 2 по имени:");
            var input = Console.ReadLine();
            var isNum = int.TryParse(input, out int choise);
            while (!isNum)
            {
                Console.WriteLine("Ошибка, введите команду еще раз");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out choise);
            }
            switch (choise)
            {
                case 1:
                    {
                        Console.Write("Введите PID: ");
                        try
                        {
                            KillById(int.Parse(Console.ReadLine()));
                        }
                        catch
                        {
                            Console.WriteLine("Неверный ввод");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Введите имя процесса: ");
                        KillByName(Console.ReadLine());
                        break;
                    }
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }
    }
}