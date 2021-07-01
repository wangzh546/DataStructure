using System;
using System.Collections.Generic;
using System.Text;

namespace sortDemo
{
    class BubbleSort : BaseSort
    {
        public override int Sort(int[] arr)
        {
            var calcCount = 0;
            //for (int i = arr.Length - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        calcCount++;
            //        if (arr[j] > arr[j + 1])
            //        {

            //            _swap(ref arr[j], ref arr[j + 1]);
            //        }
            //    }
            //}


            ////错误优化： 变成类似选择排序。【优化减少交换次数】
            //for (int i = arr.Length - 1; i > 0; i--)
            //{
            //    var count = 0;//交换次数
            //    var value_max = arr[i];//最大值
            //    var index_max = i;//最大值索引
            //    for (int j = 0; j < i; j++)
            //    {
            //        calcCount++;
            //        if (arr[j] > value_max)
            //        {
            //            value_max = arr[j];
            //            index_max = j;
            //            count++;
            //        }
            //    }
            //    if (count == 0)
            //    {
            //        return;
            //    }
            //    if (index_max != i)
            //    {
            //        _swap(ref arr[index_max], ref arr[i]);//最大值与i交换
            //    }
            //}


            //正确优化：【通过统计交换次数，提升最优时间】
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    calcCount++;//计算次数
                    if (arr[j] > arr[j + 1])
                    {
                        _swap(ref arr[j], ref arr[j + 1]);
                        count++;

                    }
                }
                if (count == 0)
                {
                    break;
                }
            }
            return calcCount;

        }
    }
}
