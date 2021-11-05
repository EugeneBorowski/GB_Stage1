using System;

namespace GB_Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var dimension = 9;
            var array = new int[dimension, dimension];
            for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(0, 9);
            }
            var space = "";
            for (int i = 0; i < array.GetLength(0);)
            for (int j = 0; j < array.GetLength(1);)
            {
                Console.Write(space + array[i, j] + "\n");
                i++;
                j++;
                space += " ";
            }
        }
    }
}
