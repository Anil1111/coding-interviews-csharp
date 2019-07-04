using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingInterviews
{
    public class ListNode
    {
        public int item;
        public ListNode next;
        public ListNode(int x)
        {
            item = x;
        }
    }

    /// <summary>
    /// 链表:从尾到头打印链表
    /// 输入一个链表，按链表值从尾到头的顺序返回一个ArrayList。
    /// </summary>
    public class Coding003
    {
        /// <summary>
        /// 栈的方式实现
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        public static List<int> PrintForStack(ListNode nodes)
        {
            Stack<ListNode> listNodes = new Stack<ListNode>();
            ListNode node = nodes;
            while (node != null)
            {
                listNodes.Push(node);
                node = node.next;
            }

            List<int> list = new List<int>();
            foreach (var item in listNodes) {
                list.Add(item.item);
            }
            return list;
        }

        /// <summary>
        /// 递归的方式实现
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<int> PrintForRecursion(ListNode node) {
            List<int> listNodes = new List<int>();
            PrintForRecursion(node, listNodes);
            return listNodes;
        }

        private static void PrintForRecursion(ListNode node, List<int> list)
        {
            if (node != null) {
                if (node.next != null) {
                    PrintForRecursion(node.next, list);
                }
                list.Add(node.item);
            }
        }

        /// <summary>
        /// 生成链表
        /// </summary>
        /// <param name="length"></param>
        public static ListNode CreateNodeList(int length)
        {
            ListNode listNode = new ListNode(0);
            var temp = listNode;
            for (int i = 1; i < length; i++)
            {
                temp = nextList(temp, i);
            }

            return listNode;

            //下一个
            ListNode nextList(ListNode node, int value)
            {
                while (node.next != null)
                {
                    node = node.next;
                }
                var next = new ListNode(value);
                node.next = next;
                return next;
            }

        }

    }
}
