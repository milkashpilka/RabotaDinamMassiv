using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividApp1
{
    using System;

    class Program
    {
        static int SumUpperLeftTriangle(int[,] square)
        {
            int sum = 0;
            int size = square.GetLength(0); 
            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j <= size - 1 - i; j++)
                {
                    sum += square[i, j];
                }
            }         
            return sum;
        }
        static void Main()
        {
            int[,] square = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };
            int sum = SumUpperLeftTriangle(square);
            Console.WriteLine($"Сумма элементов в левой верхней заштрихованной области: {sum}");
            Console.ReadKey();
        }
    }
}