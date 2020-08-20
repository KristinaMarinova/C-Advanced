using System;
using System.Linq;
class JaggedArrayModification
{
    class StartUp
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new int[size][];

            for (int rows = 0; rows < size; rows++)
            {
                var elements = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray();

                matrix[rows] = elements;
            }

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var commandArgs = input.Split();

                var command = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);

                var areCoordinatesValid = false;

                if (matrix.GetLength(0) > row && row >= 0)
                {
                    if (matrix[row].Length > col && col >= 0)
                    {
                        areCoordinatesValid = true;
                    }
                }

                switch (command)
                {
                    case "Add":
                        if (!areCoordinatesValid)
                        {
                            Console.WriteLine("Invalid coordinates");
                            break;
                        }

                        matrix[row][col] += value;

                        break;
                    case "Subtract":
                        if (!areCoordinatesValid)
                        {
                            Console.WriteLine("Invalid coordinates");
                            break;
                        }

                        matrix[row][col] -= value;

                        break;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }
    }
}