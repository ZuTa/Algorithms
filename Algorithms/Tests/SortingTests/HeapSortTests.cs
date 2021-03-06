﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorting.SortingAlgorithmsLibrary;

namespace SortingTests
{
    [TestClass]
    public class HeapSortTests : BaseSortTest
    {
        [TestInitialize]
        public void Initialize()
        {
            sorter = new HeapSort<int>();
        }

        [TestMethod]
        public void HeapSortTests_SimpleTest()
        {
            ExecuteSimpleSortTest();
        }

        [TestMethod]
        public void HeapSortTests_RandomLargeTest()
        {
            ExecuteRandomLargeSortTest();
        }
    }
}
