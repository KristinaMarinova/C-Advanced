using System;
using System.Collections.Generic;
public class RecordUniqueNames
{
    public static void Main()
    {
        int namesCount = int.Parse(Console.ReadLine());
        var uniqueNames = new HashSet<string>();

        for (int i = 0; i < namesCount; i++)
        {
            string name = Console.ReadLine();
            uniqueNames.Add(name);
        }

        foreach (var name in uniqueNames)
        {
            Console.WriteLine(name);
        }
    }
}