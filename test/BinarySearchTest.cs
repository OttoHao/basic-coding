using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCoding;
using System;

namespace BasicCodingTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void BinarySearch()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var index = BinarySearchUtility.BinarySearch(numbers, 7);
            Console.WriteLine(index);
        }

        [TestMethod]
        public void BinarySearchRecursively()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var index = BinarySearchUtility.BinarySearchRecursively(numbers, 0, numbers.Length - 1, 7);
            Console.WriteLine(index);
        }

    }
}
