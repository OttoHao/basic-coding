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
            var sol = new ReconstructQueueSolution();
            var input = new int[6][];
            input[0] = new int[2]{7,0};
            input[1] = new int[2]{4,4};
            input[2] = new int[2]{7,1};
            input[3] = new int[2]{5,0};
            input[4] = new int[2]{6,1};
            input[5] = new int[2]{5,2};
            var ret = sol.ReconstructQueue(input);

            foreach (var item in ret)
            {
                System.Console.WriteLine($"{item[0]}, {item[1]}");
            }
        }





    }



}

