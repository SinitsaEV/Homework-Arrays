using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            int lastIndex = numbers.Length - 1;

            Random random = new Random();
            int maxRandomValue = 99;
            int minRandomValue = 0;

            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomValue, maxRandomValue + 1);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Локальные максимумы: ");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < numbers.Length - 1; i++) 
            {                
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if(numbers[lastIndex] > numbers[lastIndex - 1])
            {
                Console.Write(numbers[lastIndex]);
            }
        }
    }
}
