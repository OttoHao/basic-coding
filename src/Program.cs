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
            var a = new TreeNode(1);
            var b = new TreeNode(2);
            var c = new TreeNode(3);
            var d = new TreeNode(4);
            var e = new TreeNode(5);
            var f = new TreeNode(6);
            var g = new TreeNode(7);
            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Left = f;
            c.Right = g;

            var sol = new MostCommonAncestorSolution();

            var ret = sol.FindMostComonAncestor(null, null, null);
            if(ret==null){
                System.Console.WriteLine("can not find common ancestor");
            }
            System.Console.WriteLine($"{ret?.Value}");

        }
    }
}

