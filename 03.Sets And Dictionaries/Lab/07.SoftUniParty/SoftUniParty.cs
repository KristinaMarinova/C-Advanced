using System;
using System.Collections.Generic;
public class SoftuniParty
{
    public static void Main()
    {
        var reqularGuests = new HashSet<string>();
        var vipGuests = new HashSet<string>();

        while (true)
        {
            string guest = Console.ReadLine();
            if (guest == "PARTY")
            {
                break;
            }

            if (char.IsDigit(guest[0]))
            {
                vipGuests.Add(guest);
            }
            else
            {
                reqularGuests.Add(guest);
            }
        }

        while (true)
        {
            string guest = Console.ReadLine();
            if (guest == "END")
            {
                break;
            }

            if (char.IsDigit(guest[0]))
            {
                vipGuests.Remove(guest);
            }
            else
            {
                reqularGuests.Remove(guest);
            }
        }

        Console.WriteLine(vipGuests.Count + reqularGuests.Count);

        if (vipGuests.Count > 0)
        {
            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }
        }

        if (reqularGuests.Count > 0)
        {
            foreach (var guest in reqularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}