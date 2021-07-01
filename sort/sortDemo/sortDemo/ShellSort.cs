using System;
using System.Collections.Generic;
using System.Text;

namespace sortDemo
{
    class ShellSort : BaseSort
    {
        //4\2\1方式
        public int Sort1(int[] arr)
        {
            var calcCount = 0;
            //计算初始间隔
            List<int> limits = new List<int>() { 4, 2, 1 };
            foreach (var limit in limits)
            {
                for (int offset = 0; offset < limit; offset++)
                {
                    calcCount += _insertionSort(arr, limit, offset);
                }
            }
            return calcCount;
        }

        //h = h * 3 + 1方式
        public override int Sort(int[] arr)
        {
            var calcCount = 0;
            //计算初始间隔
            List<int> limits = new List<int>() { 1 };
            int h = 1;
            while (true)
            {
                h = h * 3 + 1;
                if (h >= arr.Length)
                {
                    break;
                }
                limits.Insert(0, h);
            }
            foreach (var limit in limits)
            {
                for (int offset = 0; offset < limit; offset++)
                {
                    calcCount += _insertionSort(arr, limit, offset);
                }
            }
            return calcCount;
        }
        public int _insertionSort(int[] arr, int limit, int offset)
        {
            var calcCount = 0;
            //优化2
            for (int i = offset + limit; i < arr.Length; i += limit)
            {
                for (int j = i; j > offset && arr[j] < arr[j - limit]; j -= limit)
                {
                    calcCount++;
                    _swap(ref arr[j], ref arr[j - limit]);
                }
            }
            return calcCount;
        }
    }
}
