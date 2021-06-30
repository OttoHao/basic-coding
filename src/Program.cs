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
            var sol = new FindDisappearedNumbersSolution();
            var input = new int[]{4,3,2,7,8,2,3,1};
            var ret = sol.FindDisappearedNumbers(input);
            foreach (var item in ret)
            {
                System.Console.WriteLine(item);
            }
        }





    }



}

