using System;
using System.Collections.Generic;
using System.IO;

namespace test
{
    public class Program
    {
        static void RecursiveWriteDir(string file, string path, int dimension)
        {
            var separator = new string(' ', dimension);
            var dirList = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dirList.GetDirectories();
            FileInfo[] files = dirList.GetFiles();
            foreach (var e in dirs)
            {
                SaveAndPrint($"{separator}dir: {e.Name}");
                var tempDir = path + @"\" + e.Name;
                RecursiveWriteDir(file, tempDir, ++dimension);
                dimension--;
            }
            foreach (var e in files)
            {
                SaveAndPrint($"{separator}file: {e.Name}");
            }
            void SaveAndPrint(string text)
            {
                Console.WriteLine(text);
                File.AppendAllText(file, $"\n" + text);
            }
        }

        static void NoRecursiveWriteDir(string file, string path)
        {
            var dirs = new Queue<string>();
            dirs.Enqueue(path);

            while (dirs.Count > 0)
            {
                string dir = dirs.Dequeue();
                Console.WriteLine("dir: " + dir);
                File.AppendAllText(file, $"\ndir: {dir}");
                foreach (var d in Directory.GetDirectories(dir))
                    dirs.Enqueue(d);
                foreach (var f in Directory.GetFiles(dir))
                {
                    Console.WriteLine("  file: " + f);
                    File.AppendAllText(file, $"\n  file: {f}");
                }
            }
        }

        public static void Main()
        {
            var dimension = 0;
            var file = "file.txt";
            Console.Write("Введите путь: ");
            var path = Console.ReadLine();
            Console.WriteLine("RecursiveMethod");
            File.WriteAllText(file, "RecursiveMethod:\n");
            RecursiveWriteDir(file, path, dimension);
            Console.WriteLine("NoRecursiveDirectMethod");
            File.AppendAllText(file, "NoRecursiveDirectMethod:\n");
            NoRecursiveWriteDir(file, path);
            Console.ReadLine();
        }
    }
}