using System;
using System.Collections.Generic;
using System.Text;

namespace sortDemo
{
    /// <summary>
    /// 插入排序
    /// </summary>
    class InsertionSort : BaseSort
    {

        public override int Sort(int[] arr)
        {
            var calcCount = 0;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        calcCount++;
            //        if (arr[j] < arr[j - 1])
            //        {
            //            _swap(ref arr[j], ref arr[j - 1]);
            //        }
            //    }
            //}
            ////优化1
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        calcCount++;
            //        if (arr[j] < arr[j - 1])
            //        {
            //            _swap(ref arr[j], ref arr[j - 1]);
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            //优化2
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0 && arr[j] < arr[j - 1]; j--)
                {
                    calcCount++;
                    _swap(ref arr[j], ref arr[j - 1]);
                }
            }
            return calcCount;
        }
    }
}
