using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string description = "Unity — это мощная кроссплатформенная игровая движок и среда разработки, " +
                "созданная компанией Unity Technologies. Он широко используется для создания 2D и 3D игр, " +
                "а также интерактивных приложений и виртуальной реальности.";
            string[] descriptionWords = description.Split(' ');

            foreach (string word in descriptionWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}