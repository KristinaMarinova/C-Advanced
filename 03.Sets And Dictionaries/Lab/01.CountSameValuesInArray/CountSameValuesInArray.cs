using System;
using System.Collections.Generic;
using System.Linq;
class CountSameValuesInArray
{
    static void Main()
    {
        var inputArr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        var occurences = new Dictionary<double, int>();

        foreach (var number in inputArr)
        {
            if (occurences.ContainsKey(number))
            {
                occurences[number]++;
            }
            else
            {
                occurences[number] = 1;
            }
        }

        foreach (var occurence in occurences)
        {
            Console.WriteLine($"{occurence.Key} - {occurence.Value} times");
        }
    }
}
