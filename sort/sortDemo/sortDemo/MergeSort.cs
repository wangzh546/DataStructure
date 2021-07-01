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
            _mergeSort2(aar1);
            return _clacCount;
        }
        private void _mergeSort(int[] arr)
        {

            int[] arr1 = new int[arr.Length];
            var half = arr.Length / 2;
            int k = 0;//新数组指针
            int i = 0;
            int j = half;
            while (k < arr.Length)
            {
                _clacCount++;//计数
                if (i >= half)
                {
                    arr1[k] = arr[j];
                    j++;
                }
                else if (j >= arr.Length)
                {
                    arr1[k] = arr[i];
                    i++;
                }
                else
                {
                    if (arr[i] < arr[j])
                    {
                        arr1[k] = arr[i];
                        i++;
                    }
                    else
                    {
                        arr1[k] = arr[j];
                        j++;
                    }
                }

                k++;
            }

            //替换
            for (int n = 0; n < arr.Length; n++)
            {
                arr[n] = arr1[n];
            }

        }
        //优化
        private void _mergeSort2(int[] arr)
        {

            int[] arr1 = new int[arr.Length];
            var half = arr.Length / 2;
            int k = 0;//新数组指针
            int i = 0;
            int j = half;
            while (i < half && j < arr.Length)
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
            while (i < half) arr1[k++] = arr[i++];
            while (j < arr.Length) arr1[k++] = arr[j++];
            //替换
            for (int n = 0; n < arr.Length; n++)
            {
                arr[n] = arr1[n];
            }

        }
    }
}
