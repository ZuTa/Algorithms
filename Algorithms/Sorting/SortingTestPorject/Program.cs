﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Algorithms.Sorting.SortingAlgorithmsLibrary;

namespace SortingTestPorject
{
    class Program
    {
        private static Stopwatch stopwatch = new Stopwatch();

        private static ISort<int>[] sortingAlgorithms = 
                        {
                            //new BinarySearchTreeSort<int>(),
                            //new HeapSort<int>(),
                            new MergeSort<int>(),
                            new BottomUpMergeSort<int>(),
                            new QuickSort<int>(),
                        };

        static void Main(string[] args)
        {
            //RandomTest();

            //AlreadyInOrderTest();

            AlreadyInOrderTest2();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void AlreadyInOrderTest()
        {
            Console.WriteLine("*** Already In Order Test ***");

            int n = 10000000;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = 1713 * 13 + i;
            }

            DoSorting(array);

            Console.WriteLine();
        }

        private static void AlreadyInOrderTest2()
        {
            Console.WriteLine("*** Already In Order Test - 2 ***");

            List<int> a = new List<int>();
            int n = 250000;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a.Add(i * 1331 - j);
                }
            }

            DoSorting(a.ToArray());

            Console.WriteLine();
        }

        private static void RandomTest()
        {
            Console.WriteLine("*** Random Test ***");
            
            Random r = new Random();

            int n = 1000000;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(int.MaxValue) - r.Next(int.MaxValue);
            }

            DoSorting(array);

            Console.WriteLine();
        }

        private static void DoSorting(int[] array)
        {
            foreach(ISort<int> sorter in sortingAlgorithms)
            {
                Sort(sorter, array);
            }
        }

        private static void Sort(ISort<int> sorter, int[] array)
        {
            stopwatch.Start();
            sorter.Sort(array);
            stopwatch.Stop();

            Console.WriteLine("{0} - {1:00} ms", sorter.Name, stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();
        }
    }
}
