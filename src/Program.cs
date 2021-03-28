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

            
            var sol = new MostCommonAncestorIIISolution();

                       
            var path = sol.GetPath(a, g);

            foreach (var item in path)
            {
                System.Console.WriteLine(item.Value);
            }
        }


        /*
                        a(1)
                b(2)               c(3)
            d(4)       e(5)       f(6)       g(7)
        */
        private static GeneralTreeNode GenerateGeneralTree()
        {
            var a = new GeneralTreeNode(1);
            var b = new GeneralTreeNode(2);
            var c = new GeneralTreeNode(3);
            var d = new GeneralTreeNode(4);
            var e = new GeneralTreeNode(5);
            var f = new GeneralTreeNode(6);
            var g = new GeneralTreeNode(7);

            a.Children = new List<GeneralTreeNode>() { b, c };
            b.Children = new List<GeneralTreeNode>() { d, e };
            c.Children = new List<GeneralTreeNode>() { f, g };

            return a;
        }


        
    }



}

