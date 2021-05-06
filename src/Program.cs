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
            var a = "ccacccbcab";
            var b = new List<string>() { "cc", "bb", "aa", "bc", "ac", "ca", "ba", "cb" };
            var sol = new WordBreakSolution();
            sol.WordBreak(a, b);
        }





    }



}

