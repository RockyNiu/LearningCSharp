﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsInCSharp;

namespace AlgorithmsInCSharpTest
{

    [TestClass]
    public class QuickSortTest
    {
        private static QuickSortSolution solution;

        [ClassInitialize]
        public static void QuickSortTest_ClassInitialize(TestContext context)
        {
            solution = new QuickSortSolution();
        }

        [ClassCleanup]
        public static void QuickSortTest_ClassCleanup()
        {
        }

        [TestMethod]
        public void QuickSortTest_Empty()
        {
            int[] input = { };
            int[] excepted = { };

            int[] actual = solution.Sort(input);
            CollectionAssert.AreEqual(excepted, actual);

        }

        [TestMethod]
        public void QuickSortTest_OneItem()
        {
            int[] input = { 1 };
            int[] excepted = { 1 };

            int[] actual = solution.Sort(input);
            CollectionAssert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void QuickSortTest_TwoItems()
        {
            int[] input = { 2, 1 };
            int[] excepted = { 1, 2 };

            int[] actual = solution.Sort(input);
            CollectionAssert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void QuickSortTest_Random()
        {
            int[] input1 = { 2, 3, 1, 5, 4 };
            int[] excepted1 = { 1, 2, 3, 4, 5 };

            int[] input2 = { 2, 3, 4, 1, 3 };
            int[] excepted2 = { 1, 2, 3, 3, 4 };

            int[] actual1 = solution.Sort(input1);
            CollectionAssert.AreEqual(excepted1, actual1);

            int[] actual2 = solution.Sort(input2);
            CollectionAssert.AreEqual(excepted2, actual2);
        }

        [TestMethod]
        public void QuickSortTest_Ascending()
        {
            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] excepted1 = { 1, 2, 3, 4, 5 };

            int[] input2 = { 1, 2, 3, 3, 4 };
            int[] excepted2 = { 1, 2, 3, 3, 4 };

            int[] actual1 = solution.Sort(input1);
            CollectionAssert.AreEqual(excepted1, actual1);

            int[] actual2 = solution.Sort(input2);
            CollectionAssert.AreEqual(excepted2, actual2);
        }

        [TestMethod]
        public void QuickSortTest_Descending()
        {
            int[] input1 = { 5, 4, 3, 2, 1 };
            int[] excepted1 = { 1, 2, 3, 4, 5 };

            int[] input2 = { 4, 3, 3, 2, 1 };
            int[] excepted2 = { 1, 2, 3, 3, 4 };

            int[] actual1 = solution.Sort(input1);
            CollectionAssert.AreEqual(excepted1, actual1);

            int[] actual2 = solution.Sort(input2);
            CollectionAssert.AreEqual(excepted2, actual2);
        }
    }
}
