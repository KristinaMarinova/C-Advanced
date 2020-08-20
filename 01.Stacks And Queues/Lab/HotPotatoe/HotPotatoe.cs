using System;
using System.Collections.Generic;

namespace HotPotatoe
{
    class HotPotatoe
    {
        public static void Main()
        {
            string[] children = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int tosses = int.Parse(Console.ReadLine());

            Queue<string> theRing = new Queue<string>(children);
            while (theRing.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    theRing.Enqueue(theRing.Dequeue());
                }

                Console.WriteLine($"Removed {theRing.Dequeue()}");
            }

            Console.WriteLine($"Last is {theRing.Dequeue()}");
        }
    }
}
