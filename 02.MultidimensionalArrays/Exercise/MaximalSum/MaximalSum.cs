using System;
using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            int[] matrixSizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSizes[0];
            int cols = matrixSizes[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            int maxSum = 0;
            int[,] maxMatrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                                    matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                                    matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        maxMatrix = new int[3, 3]
                        {
                            { matrix[i, j], matrix[i, j + 1], matrix[i, j + 2] },
                            { matrix[i + 1, j], matrix[i + 1, j + 1], matrix[i + 1, j + 2] },
                            { matrix[i + 2, j], matrix[i + 2, j + 1], matrix[i + 2, j + 2] }
                        };
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < maxMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < maxMatrix.GetLength(1); j++)
                {
                    Console.Write(maxMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }