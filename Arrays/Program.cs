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
            int openBracketsCount = 0;
            int maxDepth = 0;
            int currentDepth = 0;
            bool isCorrectExpression = true;

            foreach (char bracket in brackets)
            {
                char openBracketSymbol = '(';

                if (bracket == openBracketSymbol)
                    openBracketsCount++;
                else
                    openBracketsCount--;

                if (openBracketsCount < 0)
                {
                    isCorrectExpression = false;
                    Console.WriteLine("неверное скобочное выражение");
                    break;
                }

                currentDepth = openBracketsCount;

                if (currentDepth > maxDepth)
                    maxDepth = currentDepth;
            }

            if (isCorrectExpression)
                Console.WriteLine($"максимальная глубина: {maxDepth}");
        }
    }
}