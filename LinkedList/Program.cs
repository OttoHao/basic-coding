using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new LinkNode<int>(1);
            LinkNodeUtility.Append(head, 2);
            LinkNodeUtility.Append(head, 3);
            LinkNodeUtility.Append(head, 4);
            LinkNodeUtility.Append(head, 5);

            var middle = LinkNodeUtility.GetMiddleValue(head);
            Console.WriteLine(middle.Value);

            var reserved = LinkNodeUtility.RecursiveReserve(head);
            LinkNodeUtility.Print(reserved);
        }
    }
}
