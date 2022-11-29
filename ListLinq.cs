using System;
using System.Collections.Generic;
using System.Linq;

public class ListTest
{
    static void Main()
    {
        List<int> Testlist = new List<int>(1500);

        Console.WriteLine(" How many times would you repeat? ");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        { 
            Testlist.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Capacity of this List is {Testlist.Capacity}.");
            Console.WriteLine($"The Count of this element is {Testlist.Count}.");
        }

        Testlist.TrimExcess();
        Console.WriteLine($"Capacity was trimed. Now Capacity is {Testlist.Capacity}");

        if(Testlist.Contains(78))
        {
            Console.WriteLine("it is true");
        }



        for (int i = 0; i < Testlist.Count; i++)
        {
            Console.Write($"{ Testlist[i]} ");
        }
        Console.WriteLine();

        //shit the fuck up 
        var startwithLinq =
            from items in Testlist
            where items >= 0
            where items < 11
            select items;

        foreach(int n in startwithLinq)
        {
            Console.Write($"선택된 수: {n}");
            Console.WriteLine();
        }    


        int[] cheeck = Testlist.ToArray();

        foreach(int elems in cheeck)
        {
            Console.Write($"{elems} ");
        }
        Console.WriteLine();
    }
}
