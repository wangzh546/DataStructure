using System;
using System.Collections.Generic;
using System.Text;

namespace sortDemo
{
    class SelectionSort : BaseSort
    {
        public override int Sort(int[] arr)
        {
            var calcCount = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index_min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    calcCount++;
                    if (arr[j] < arr[index_min])
                    {
                        index_min = j;
                    }
                }
                //第一个和最小标交换
                //int value = arr[i];
                //arr[i] = arr[index_min];
                //arr[index_min] = value;
                _swap(ref arr[i], ref arr[index_min]);
            }
            return calcCount;
        }
    }
}
