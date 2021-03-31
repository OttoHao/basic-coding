using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCoding
{
    /*
                a(1)
        b(2)               c(3)
    d(4)       e(5)       f(6)       g(7)
    */
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TreeNode(2);
            var b = new TreeNode(1);
            var c = new TreeNode(3);
            a.Left = b;
            a.Right = c;

            var sol = new ConvertBST2LinkListSolution();
            var ret = sol.Convert(a);

            while(ret != null){
                System.Console.WriteLine(ret?.Value);
                ret = ret.Next;
            }
        }





    }



}

