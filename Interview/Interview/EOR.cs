using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    //异或 等价 相加无进位。
    class EOR
    {
        #region 异或交换
        public static void Swap(ref int a, ref int b)
        {
            a = a ^ b; //a=a^b,b=b
            b = a ^ b; //a=a^b,b=a^b^b=a^(b^b)=a^0=a
            a = a ^ b; //a=a^b^a=b,b=a
        }
        public static void Swap(int[] arr, int i, int j)
        {
            if (i != j)
            {
                arr[i] = arr[i] ^ arr[j];
                arr[j] = arr[i] ^ arr[j];
                arr[i] = arr[i] ^ arr[j];
            }
        }
        #endregion


        #region 一个数组，一个数出现奇数次，其他数都出现偶数次，怎么找到该数。
        public static int GetOddNum1(int[] arr)
        {
            int eor = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                eor ^= arr[i];
            }
            //foreach (var i in arr)
            //{
            //    eor ^= i;
            //}
            return eor;
        }
        #endregion

        #region 一个数组，两个数出现奇数次，其他数都出现偶数次，怎么找到该数。 
        public static void GetOddNum2(int[] arr)
        {
            int eor = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                eor ^= arr[i];
            }
            var a = GetRightOne(eor);
            //eor = a^b



        }
        //   提取最右侧1，剩下都改为0 n&(!n+1)
        public static int GetRightOne(int n)
        {
            return n & (!n + 1);
        }
        #endregion
    }
}
