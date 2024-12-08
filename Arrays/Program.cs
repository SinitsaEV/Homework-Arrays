using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введите скобочное выражение: ");

            string brackets = Console.ReadLine();
            int differenceBracketsCount = 0;
            int maxDepth = 0;
            int currentDepth = 0;
            char openBracketSymbol = '(';
            bool isCorrectExpression = true;

            foreach (char bracket in brackets)
            {                
                if (bracket == openBracketSymbol)
                    differenceBracketsCount++;
                else
                    differenceBracketsCount--;

                if (differenceBracketsCount < 0)
                {
                    isCorrectExpression = false;
                    Console.WriteLine("неверное скобочное выражение");
                    break;
                }

                currentDepth = differenceBracketsCount;

                if (currentDepth > maxDepth)
                    maxDepth = currentDepth;
            }

            if (isCorrectExpression)
                Console.WriteLine($"максимальная глубина: {maxDepth}");
        }
    }
}
