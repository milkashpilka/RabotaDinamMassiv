using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamMassivApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, -3, 4, 5, 0, -2, 6, 7, 8 };
            int firstNegativeIndex = -1;
            int lastPositiveIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && firstNegativeIndex == -1)
                {
                    firstNegativeIndex = i;
                }
                if (array[i] > 0)
                {
                    lastPositiveIndex = i;
                }
            }
            if (firstNegativeIndex != -1 && lastPositiveIndex != -1 && firstNegativeIndex < lastPositiveIndex)
            {
                int product = 1;
                for (int i = firstNegativeIndex + 1; i < lastPositiveIndex; i++)
                {
                    if (array[i] != 0)
                    {
                        product *= array[i];
                    }
                }
                Console.WriteLine("Произведение элементов: " + product);
            }
            else
            {
                Console.WriteLine("Не удалось найти отрицательный и положительный элементы в нужном порядке.");
            }
            Console.ReadKey();
        }
    }
}