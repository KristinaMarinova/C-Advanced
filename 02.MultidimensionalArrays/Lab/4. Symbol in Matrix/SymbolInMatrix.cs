using System;
class SymbolInMatrix
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var matrix = new char[n, n];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            var elements = Console.ReadLine().ToCharArray();

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = elements[cols];
            }
        }

        var symbol = char.Parse(Console.ReadLine());

        var isSymbolFound = false;

        var output = string.Empty;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (isSymbolFound)
                {
                    break;
                }

                if (matrix[rows, cols] == symbol)
                {
                    output = $"({rows}, {cols})";
                    isSymbolFound = true;
                    break;
                }
            }
        }

        Console.WriteLine(String.IsNullOrEmpty(output) ? $"{symbol} does not occur in the matrix" : output);
    }
}