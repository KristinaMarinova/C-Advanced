using System;
using System.Collections.Generic;

public class TrafficJam
{
    public static void Main()
    {
        int numberOfCarsToPass = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int carsPassed = 0;
        Queue<string> cars = new Queue<string>();
        while (command != "end")
        {
            switch (command)
            {
                case "green":
                    for (int i = 0; i < numberOfCarsToPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }

                    break;
                default:
                    cars.Enqueue(command);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"{carsPassed} cars passed the crossroads.");
    }
}