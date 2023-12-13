using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamMassivApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 3, 5, 2, 7, 10, 4, 6, 9 };
            int minIndex = Array.IndexOf(array, array.Min());
            int maxIndex = Array.IndexOf(array, array.Max());
            int sum = 0;
            int count = 0;
            if (minIndex < maxIndex)
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    sum += array[i];
                    count++;
                }

                double average = (double)sum / count;
                Console.WriteLine("Среднее арифметическое: " + average);
            }
            else
            {
                Console.WriteLine("Не удалось найти минимальный и максимальный элементы в нужном порядке.");
            }
            Console.ReadKey();
        }
    }
}