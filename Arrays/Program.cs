﻿using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string exitCommand = "exit";
            const string sumCommand = "sum";

            int[] numbers = new int[0];
            int[] tempNumbers; 
            int sum;

            string playerInput;
            bool exitLoop = true;

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Команды программы:");
            Console.WriteLine($"Выйти из программы - {exitCommand}\nВывести сумму всех чисел - {sumCommand}\nВведите любое число для добавления.");

            while (exitLoop)
            {
                playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case exitCommand:
                        exitLoop = false;
                        Console.WriteLine("Вы вышли из программы.");
                        break;

                    case sumCommand:
                        sum = 0;

                        for (int i = 0; i < numbers.Length; i++)
                            sum += numbers[i];
                        
                        Console.WriteLine("Сумма всех чисел: " + sum);
                        break;

                    default:
                        tempNumbers = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                            tempNumbers[i] = numbers[i];

                        tempNumbers[tempNumbers.Length - 1] = Convert.ToInt32(playerInput);
                        numbers = tempNumbers;
                        Console.WriteLine($"Добавлено число: {playerInput}");
                        break;
                }
            }
        }
    }
}
