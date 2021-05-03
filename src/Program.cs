using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hot100;

namespace BasicCoding
{

    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList<int, int>();

            list.Add(1, 1);
            list.Add(0, 0);
            list.Add(2, 2);
            list.RemoveAt(0);
            System.Console.WriteLine(list.First());
        }





    }



}

