using System;
using System.Collections.Generic;
using System.Linq;

namespace sortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectionSort = new SelectionSort();
            var bubbleSort = new BubbleSort();
            var insertionSort = new InsertionSort();
            var shellSort = new ShellSort();
            var mergeSort = new MergeSort();
            var quickSort = new QuickSort();
            //Console.WriteLine("————选择排序————");
            //for (int i = 0; i < 10; i++)
            //{
            //    selectionSort.RunTest();
            //}
            //Console.WriteLine();

            //Console.WriteLine("————冒泡排序————");
            //for (int i = 0; i < 10; i++)
            //{
            //    bubbleSort.RunTest();
            //}
            //Console.WriteLine();
            //Console.WriteLine("冒泡排序(最优情况)");
            //bubbleSort.RunTest(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            //Console.WriteLine("————插入排序————");

            //for (int i = 0; i < 10; i++)
            //{
            //    insertionSort.RunTest();
            //}
            //Console.WriteLine();

            //Console.WriteLine("————希尔排序————");

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

            //Console.WriteLine("————归并排序————");

            //for (int i = 0; i < 10; i++)
            //{
            //    mergeSort.RunTest();
            //}
            //Console.WriteLine("————希尔vs归并排序————");
            //var arrs = new List<int[]>();
            //for (int i = 0; i < 10; i++)
            //{
            //    arrs.Add(mergeSort.BuildRandNums(20, 1000));
            //}
            //foreach (var arr in arrs)
            //{
            //    var arr1 = arr.ToArray();
            //    var arr2 = arr.ToArray();
            //    mergeSort.Show("排序前：\t", arr);

            //    var calcCount = mergeSort.Sort(arr1);
            //    mergeSort.Show($"归并排序，计算{calcCount}次：", arr1);

            //    var calcCount1 = shellSort.Sort(arr2);
            //    shellSort.Show($"希尔排序，计算{calcCount1}次：", arr2);
            //}
            //Console.WriteLine();
            //Console.WriteLine("————快速排序————");
            //for (int i = 0; i < 100; i++)
            //{
            //    quickSort.RunTest();
            //}
            //int[] arr = new int[] { 30, 54, 64, 97, 31, 18, 57, 51, 99, 29 };
            //quickSort.Sort(arr);
            //quickSort.Show("aa", arr);

            //Math.Atan()



            Console.ReadLine();



        }
    }
}
