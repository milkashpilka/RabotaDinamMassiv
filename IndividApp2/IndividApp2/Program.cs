using System;

class Program
{
    static long ProductOfRightCentralTriangle(int[,] square)
    {
        long product = 1;
        int size = square.GetLength(0); 
        bool isEven = size % 2 == 0;
        int midPoint = size / 2;
        for (int i = 0; i < size; i++)
        {
            int start = isEven ? midPoint : midPoint + 1;
            int end = size - 1 - i;
            for (int j = start; j <= end; j++)
            {
                product *= square[i, j];
            }
        }
        return product;
    }
    static void Main()
    {
        int[,] square = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };
        long product = ProductOfRightCentralTriangle(square);
        Console.WriteLine($"Произведение элементов в правом центральном треугольнике: {product}");
        Console.ReadKey();
    }
}