using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];

            Random random = new Random();
            int maxRandomValue = 100;
            int minRandomValue = 0;

            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandomValue, maxRandomValue + 1);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Локальные максимумы: ");

            if (array[0] > array[1])
            {
                Console.Write(array[0] + " ");
            }

            for (int i = 1; i < array.Length - 1; i++) 
            {                
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if(array[array.Length - 1] > array[array.Length - 2])
            {
                Console.Write(array[array.Length - 1]);
            }
        }
    }
}
