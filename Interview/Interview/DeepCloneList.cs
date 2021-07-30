using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DeepCloneList
{
    /// <summary>
    /// 深度克隆
    /// </summary>
    class DeepCloneList
    {

    }
    class Node 
    {
        public Node(int val)
        {
            value = val;
        }

        public int value { get; set; }
        public Node next { get; set; }
        public Node rand { get; set; }


        public void Show(string title)
        {
            Console.Write(title + "\t");
            var node = this;
            while (node != null)
            {
                Console.Write(node.value + "\t");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
