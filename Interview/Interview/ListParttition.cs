using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    class ListParttition
    {
        public static Node GetRandonList(int length, int max)
        {
            if (length == 0)
            {
                return null;
            }
            var random = new Random();
            var headN = new Node(random.Next(max));
            var nextN = headN;
            for (int i = 1; i < length; i++)
            {
                var node = new Node(random.Next(max));
                nextN.next = node;
                nextN = node;
            }
            return headN;
        }

        public static Node Parttition(Node head, int pivot)
        {
            Node sH = null, sT = null;
            Node eH = null, eT = null;
            Node mH = null, mT = null;
            while (head != null)
            {
                if (head.value < pivot)
                {
                    if (sH == null)
                    {
                        sH = head;
                        sT = head;
                    }
                    else
                    {
                        sT.next = head;
                        sT = head;
                    }
                }
                else if (head.value == pivot)
                {
                    if (eH == null)
                    {
                        eH = head;
                        eT = head;
                    }
                    else
                    {
                        eT.next = head;
                        eT = head;
                    }

                }
                else
                {
                    if (mH == null)
                    {
                        mH = head;
                        mT = head;
                    }
                    else
                    {
                        mT.next = head;
                        mT = head;
                    }
                }
                head = head.next;
            }
            if (sT != null)
            {
                sT.next = eH;
                eT = eT == null ? sT : eT;//等于区域可以没有，就使用sT
            }
            if (eT != null)
            {
                eT.next = mH;
            }
            if (mT != null)
            {
                mT.next = null;
            }
            return sH != null ? sH : (eH != null ? eH : mH);
        }
    }
    class Node
    {
        public Node(int val)
        {
            value = val;
        }

        public int value { get; set; }
        public Node next { get; set; }


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
