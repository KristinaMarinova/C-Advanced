using System;
using System.Linq;

class SumMatrixColumns
{
    static void Main(string[] args)
    {
        var rowsColsCount = Console.ReadLine()
            .Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        var matrix = new int[rowsColsCount[0], rowsColsCount[1]];
        var colSumArray = new int[rowsColsCount[1]];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            var matrixElemnts = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = matrixElemnts[cols];
                colSumArray[cols] += matrix[rows, cols];
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, colSumArray));
    }
}