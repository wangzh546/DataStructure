using System;
using System.Collections.Generic;
using System.Text;

namespace sortDemo
{
    class HeapSort : BaseSort
    {
        int _calcCount;
        public override int Sort(int[] arr)
        {
            _calcCount = 0;
            //一个一个heapInsert  复杂度O(n*log n)
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    _heapInsert(arr, i);
            //}
            //优化: arr使用heapify 变成大根堆(反序遍历，下沉)  复杂度O(n)
            for (int i = arr.Length - 1; i > -1; i--)
            {
                _heapify(arr, i, arr.Length);
            }
            //排序
            var heapSize = arr.Length;
            while (heapSize > 0)
            {
                _swap(arr, 0, --heapSize);
                _heapify(arr, 0, heapSize);
            }
            return _calcCount;
        }
        //（大根）堆插入
        private void _heapInsert(int[] arr, int index)
        {
            while (arr[index] > arr[(index - 1) / 2]) //插入的大于p
            {
                _swap(arr, index, (index - 1) / 2);
                index = (index - 1) / 2;
                _calcCount++;
            }
        }

        //（大根）堆化
        private void _heapify(int[] arr, int index, int heapSize)
        {
            //有孩子
            int left = index * 2 + 1;
            while (left < heapSize)//有子
            {
                //找大的孩子
                int largest = left + 1 < heapSize && arr[left] < arr[left + 1] ? left + 1 : left;
                if (arr[largest] < arr[index])
                {
                    break;
                }
                _swap(arr, index, largest);
                index = largest;
                left = index * 2 + 1;

                _calcCount++;
            }
        }

    }
}
