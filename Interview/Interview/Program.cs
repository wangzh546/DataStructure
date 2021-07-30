using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //EOR.Swap(ref a, ref b);
            //Console.WriteLine($"a={a},b={b}");

            //var arr = new int[] { 11, 2, 33, 23, 6 };
            //EOR.Swap(arr, 1, 2);

            //Console.WriteLine($"arr=[{string.Join(",", arr)}]");

            //var arr1 = new int[] { 1, 2, 3, 1, 3, 2, 4, 1, 1, 4, 3 };
            //Console.WriteLine(EOR.GetOddNum1(arr1));

            var haed = ListParttition.GetRandonList(10, 100);
            haed.Show("链表：");
            var haed1 = ListParttition.Parttition(haed, haed.value);
            haed1.Show("haed1：");
            //var haed2 = ListParttition.Parttition(haed, haed.next.value);
            //haed2.Show("haed2：");
            //var haed3 = ListParttition.Parttition(haed, haed.next.next.value);
            //haed3.Show("haed3：");
            //var haed4 = ListParttition.Parttition(haed, haed.next.next.next.value);
            //haed4.Show("haed4：");

        }
    }
}
