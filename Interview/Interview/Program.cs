using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            EOR.Swap(ref a, ref b);
            Console.WriteLine($"a={a},b={b}");

            var arr = new int[] { 11, 2, 33, 23, 6 };
            EOR.Swap(arr, 1, 2);

            Console.WriteLine($"arr=[{string.Join(",", arr)}]");

            var arr1 = new int[] { 1, 2, 3, 1, 3, 2, 4, 1, 1, 4, 3 };
            Console.WriteLine(EOR.GetOddNum1(arr1));

        }
    }
}
