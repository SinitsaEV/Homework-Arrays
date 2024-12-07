using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            int maxRandomValue = 5;
            int minRandomValue = 0;

            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomValue, maxRandomValue + 1);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {               
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int buffer = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = buffer;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine();
        }
    }
}
