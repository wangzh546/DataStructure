using System;
using System.Collections.Generic;
using System.Text;

namespace sortDemo
{
    class QuickSort : BaseSort
    {
        int _clacCount;
        public override int Sort(int[] arr)
        {
            _clacCount = 0;
            _sort(arr, 0, arr.Length - 1);
            return _clacCount;
        }

        private void _sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            var index = _partition(arr, left, right);
            _sort(arr, left, index - 1);
            _sort(arr, index + 1, right);
        }
        private int _partition(int[] arr, int left, int right)//荷兰国旗问题
        {
            //找一个中位数，放到最后
            int pivot = arr[right];
            while (left < right)
            {
                while (arr[left] <= pivot && left < right) left++;
                arr[right] = arr[left];
                while (arr[right] >= pivot && right > left) right--;
                arr[left] = arr[right];
                _clacCount++;
            }
            arr[right] = pivot;
            //Show($"partition:", arr);
            return left;
        }
        public void _partition2()
        {

        }


    }
}
