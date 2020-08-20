using System;
using System.Linq;

class PrimaryDiagonal
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var matrix = new int[n, n];

        int sum = 0;
        int colNumber = 0;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            var elements = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = elements[colNumber];
            }

            sum += matrix[rows, colNumber++];
        }

        Console.WriteLine(sum);
    }
}