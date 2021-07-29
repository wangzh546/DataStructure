using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortDemo
{
    //归并排序
    class MergeSort : BaseSort
    {
        int _clacCount;
        public override int Sort(int[] arr)
        {
            _clacCount = 0;
            _sort(arr, 0, arr.Length);
            return _clacCount;
        }



        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="start">开始</param>
        /// <param name="length">长度</param>
        private void _sort(int[] arr, int start, int length)
        {
            //只有一个数
            if (length == 1)
            {
                return;
            }
            int mid = start + (length) / 2;
            _sort(arr, start, mid - start);
            _sort(arr, mid, start + length - mid);

            _merge(arr, start, mid, length);
        }
        /// <summary>
        /// 归并
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="leftPtr">左指针</param>
        /// <param name="rightPtr">右指针</param>
        /// <param name="endPtr">结束指针</param>
        private void _merge(int[] arr, int leftPtr, int rightPtr, int length)
        {
            if (leftPtr < 0 || rightPtr < 0)
            {
                throw new ArgumentException("leftPtr and rightPtr can not be empty");
            }
            if (rightPtr < leftPtr)
            {
                throw new ArgumentException("rightPtr must be greater than leftPtr");
            }
            int[] arr1 = new int[length];//新数组
            int k = 0;//新数组指针
            int rightBound = leftPtr + length;//右边界
            int i = leftPtr;
            int j = rightPtr;
            while (i < rightPtr && j < rightBound)
            {
                _clacCount++;//计数
                if (arr[i] < arr[j])
                {
                    arr1[k++] = arr[i++];
                }
                else
                {
                    arr1[k++] = arr[j++];
                }
            }
            //其一先排完成跳出循环，后面的直接接上
            while (i < rightPtr) arr1[k++] = arr[i++];
            while (j < rightBound) arr1[k++] = arr[j++];

            //替换
            for (int n = 0; n < arr1.Length; n++)
            {
                arr[leftPtr + n] = arr1[n];
            }
        }
    }
}
