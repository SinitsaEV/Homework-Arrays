using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int maxValue = int.MinValue;
            int replaceValue = 0;

            Random random = new Random();

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Изначальная матрица:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            foreach(int number in array)
            {
                if (maxValue < number)
                    maxValue = number;
            }

            Console.WriteLine($"Максимальное число: {maxValue}.");
            Console.WriteLine("Итоговая матрица:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i, j] == maxValue)
                    {
                        array[i, j] = replaceValue;
                    }

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
