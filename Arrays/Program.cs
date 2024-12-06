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
            int[,] array = new int[5, 6];
            int sum = 0;
            int product = 1;
            int lineIndex = 2;
            int columnIndex = 1;

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(1); i++)
                sum += array[lineIndex - 1, i];

            for (int i = 0; i < array.GetLength(0); i++)
                product *= array[i, columnIndex - 1];

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Сумма {lineIndex} строки = {sum} ");
            Console.WriteLine($"Произведение {columnIndex} столбца = {product} ");
        }
    }
}
