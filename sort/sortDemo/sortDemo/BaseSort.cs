using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace sortDemo
{
    abstract class BaseSort
    {
        protected void _swap(ref int v1, ref int v2)
        {
            int value = v1;
            v1 = v2;
            v2 = value;
        }
        protected void _swap(int[] arr, int index1, int index2)
        {
            if (index1 == index2)
            {
                return;
            }
            int value = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = value;
        }
        public int[] BuildRandNums(int count, int max)
        {
            int[] arr = new int[count];
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = random.Next(0, max);
            }
            return arr;
        }
        public void Show(string title, int[] arr)
        {
            Console.Write(title + "\t");
            foreach (var i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        public void Check(int[] arr, int calcCount)
        {
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] > arr[i + 1])
            //    {
            //        Console.WriteLine($"×（第{i}个）");
            //        return;
            //    }
            //}
            var arr2 = arr.OrderBy(i => i).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr2[i] != arr[i])
                {
                    Console.WriteLine($"×（第{i}个）");
                    return;
                }
            }

            Console.WriteLine($"√ (计算{calcCount}次)");
        }

        public void RunTest(int[] arr)
        {
            Show("排序前:", arr);
            var calcCount = Sort(arr);
            Show("排序后:", arr);
            Check(arr, calcCount);
        }
        public void RunTest(int count = 10, int max = 100)
        {
            var arr = BuildRandNums(count, max);
            Show("排序前:", arr);
            var calcCount = Sort(arr);
            Show("排序后:", arr);
            Check(arr, calcCount);
        }
        public abstract int Sort(int[] arr);
    }
}
