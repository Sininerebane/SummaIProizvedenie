using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SummaIProizvedenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] array = new int[3, 3];
            int minElement = 1;
            int maxElement = 11;
            int sum = 0;
            int multiplication = 1;
            int lineNumber = 1;
            int rowNumber = 0;
            Random random = new Random();


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minElement, maxElement);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[lineNumber, j];
            }

            Console.WriteLine($"Cумму второй строки: {sum}");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplication *= array[i, rowNumber];

            }

            Console.WriteLine($"Произведение первого столбца: {multiplication}");
            Console.ReadKey();
        }
    }
}


