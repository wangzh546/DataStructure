using System;
using System.Collections.Generic;
using System.Linq;

namespace sortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("————选择排序————");
            //var selectionSort = new SelectionSort();
            //for (int i = 0; i < 10; i++)
            //{
            //    selectionSort.RunTest();
            //}
            //Console.WriteLine();

            //Console.WriteLine("————冒泡排序————");
            //var bubbleSort = new BubbleSort();
            //for (int i = 0; i < 10; i++)
            //{
            //    bubbleSort.RunTest();
            //}
            //Console.WriteLine();
            //Console.WriteLine("冒泡排序(最优情况)");
            //bubbleSort.RunTest(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            //Console.WriteLine("————插入排序————");
            var insertionSort = new InsertionSort();
            //for (int i = 0; i < 10; i++)
            //{
            //    insertionSort.RunTest();
            //}
            //Console.WriteLine();

            //Console.WriteLine("————希尔排序————");
            //var shellSort = new ShellSort();
            //for (int i = 0; i < 10; i++)
            //{
            //    shellSort.RunTest();
            //}
            //Console.WriteLine();

            //Console.WriteLine("————比对插入排序和希尔排序————");

            //var arrs = new List<int[]>();
            //for (int i = 0; i < 10; i++)
            //{
            //    arrs.Add(insertionSort.BuildRandNums(10, 100));
            //    //insertionSort.RunTest();
            //}
            //foreach (var arr in arrs)
            //{
            //    var arr1 = arr.ToArray();
            //    var arr2 = arr.ToArray();
            //    insertionSort.Show("排序前：\t", arr);

            //    var calcCount = insertionSort.Sort(arr);
            //    insertionSort.Show($"插入排序，计算{calcCount}次：", arr);

            //    var calcCount1 = shellSort.Sort(arr1);
            //    shellSort.Show($"希尔排序，计算{calcCount1}次：", arr1);

            //    var calcCount2 = shellSort.Sort1(arr2);
            //    shellSort.Show($"希尔421，计算{calcCount2}次：", arr2);
            //}

            Console.WriteLine("————归并排序————");
            var mergeSort = new MergeSort();
            var arr = new int[] { 1, 4, 6, 7, 10, 2, 3, 5, 8, 9, 11 };
            var calcCount = mergeSort.Sort(arr);
            mergeSort.Show("aa", arr);
            //for (int i = 0; i < 10; i++)
            //{

            //}
            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
