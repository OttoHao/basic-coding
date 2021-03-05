using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCoding;
using System;

namespace BasicCodingTest
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void GetMiddleValue()
        {
            var head = new LinkNode<int>(1);
            LinkNodeUtility.Append(head, 2);
            LinkNodeUtility.Append(head, 3);
            LinkNodeUtility.Append(head, 4);
            LinkNodeUtility.Append(head, 5);

            var middle = LinkNodeUtility.GetMiddleValue(head);
            Console.WriteLine(middle.Value);
        }

        [TestMethod]
        public void Reserve()
        {
            var head = new LinkNode<int>(1);
            LinkNodeUtility.Append(head, 2);
            LinkNodeUtility.Append(head, 3);
            LinkNodeUtility.Append(head, 4);
            LinkNodeUtility.Append(head, 5);

            var reserved = LinkNodeUtility.Reverse(head);
            LinkNodeUtility.Print(reserved);
        }

        [TestMethod]
        public void RecursiveReserve()
        {
            var head = new LinkNode<int>(1);
            LinkNodeUtility.Append(head, 2);
            LinkNodeUtility.Append(head, 3);
            LinkNodeUtility.Append(head, 4);
            LinkNodeUtility.Append(head, 5);

            var reserved = LinkNodeUtility.RecursiveReserve(head);
            LinkNodeUtility.Print(reserved);
        }
    }
}
