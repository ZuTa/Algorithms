﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorting.SortingAlgorithmsLibrary;

namespace SortingTests
{
    [TestClass]
    public class InsertionSortTests : BaseQuadraticSortTest
    {
        [TestInitialize]
        public void Initialize()
        {
            this.sorter = new InsertionSort<int>();
        }

        [TestMethod]
        [TestCategory("Quadratic Sorts")]
        public void InsertionSortTests_SimpleTest()
        {
            ExecuteSimpleSortTest();
        }

        [TestMethod]
        [TestCategory("Quadratic Sorts")]
        public void InsertionSortTests_RandomLargeTest()
        {
            ExecuteRandomLargeSortTest();
        }
    }
}
