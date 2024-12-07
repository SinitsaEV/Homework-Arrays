using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[] numbers = new int[30];
            int maxRandomValue = 5;
            int minRandomValue = 0;

            int maxRepeatLength = 0;
            int maxRepeatNumber = 0;
            int minRepeatLength = 1;
            int currentRepeatLength = minRepeatLength;
            int currentRepeatNumber;

            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomValue, maxRandomValue + 1);
                Console.Write(numbers[i] + " ");
            }

            currentRepeatNumber = numbers[0];            

            for (int i = 1;i < numbers.Length; i++)
            {
                if(currentRepeatNumber == numbers[i])
                {
                    currentRepeatLength++;
                }
                else
                {
                    if(currentRepeatLength > maxRepeatLength)
                    {
                        maxRepeatLength = currentRepeatLength;
                        maxRepeatNumber = currentRepeatNumber;
                    }

                    currentRepeatNumber = numbers[i];
                    currentRepeatLength = minRepeatLength;
                }
                
            }
            
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine();
            Console.WriteLine($"Число {maxRepeatNumber} встречается {maxRepeatLength} раз подряд.");
        }
    }
}