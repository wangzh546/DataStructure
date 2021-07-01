using System;

namespace sortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("选择排序");
            //var selectionSort = new SelectionSort();
            //for (int i = 0; i < 10; i++)
            //{
            //    selectionSort.RunTest();
            //}
            //Console.WriteLine();

            Console.WriteLine("冒泡排序");
            var bubbleSort = new BubbleSort();
            for (int i = 0; i < 10; i++)
            {
                bubbleSort.RunTest();
            }
            Console.WriteLine();

            //Console.WriteLine("冒泡排序(最优情况)");
            //bubbleSort.RunTest(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Console.ReadLine();
        }
    }
}
