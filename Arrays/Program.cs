﻿using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 

            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введите число для сдвига: ");
            int offset = Convert.ToInt32(Console.ReadLine());

            foreach (int i in numbers)
            {
                Console.Write(i);
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length % offset; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = firstNumber;
            }

            foreach(int number in numbers)
            {
                Console.Write(number);
            }
        }
    }
}
