﻿using System;
using System.Linq;
class SumMatrixElements
{
    static void Main()
    {
        int[] sizes = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[,] matrix = new int[sizes[0], sizes[1]];
        long sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] row = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            for (int j = 0; j < row.Length; j++)
            {
                matrix[i, j] = row[j];
                sum += row[j];
            }
        }

        Console.WriteLine(matrix.GetLength(0));
        Console.WriteLine(matrix.GetLength(1));
        Console.WriteLine(sum);
    }
}