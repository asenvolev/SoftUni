using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        var revList = new ReversedList<int>();
        revList.Add(1);
        revList.Add(2);
        revList.Add(3);
        revList.RemoveAt(2);
        foreach (var num in revList)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine(revList[0]);
    }
}

