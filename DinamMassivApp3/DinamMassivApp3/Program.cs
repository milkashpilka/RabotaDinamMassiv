using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamMassivApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -2, 3, 0, -4, 5, 6, -7, 8, 0 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] *= array[i];
                }
                else if (array[i] > 0)
                {
                    array[i] /= 2;
                }
            }
            Console.WriteLine("Преобразованный массив: " + string.Join(", ", array));
            Console.ReadKey();
        }
    }
}