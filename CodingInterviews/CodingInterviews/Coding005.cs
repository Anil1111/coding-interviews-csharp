using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviews
{
    /// <summary>
    /// 栈和队列:用两个栈实现队列
    /// 用两个栈来实现一个队列，完成队列的Push和Pop操作。 队列中的元素为int类型。
    /// </summary>
    public class Coding005
    {
        /// <summary>
        /// 出栈
        /// </summary>
        private Stack<int> dequeue;
        /// <summary>
        /// 进栈
        /// </summary>
        private Stack<int> enqueue;

        public Coding005()
        {
            dequeue = new Stack<int>();
            enqueue = new Stack<int>();
        }
        /// <summary>
        /// 出栈（优化）
        /// </summary>
        /// <returns></returns>
        public int Dequeue2()
        {
            //没有数据
            if (enqueue.Count == 0 && dequeue.Count == 0) {
                return -1;
            }

            while (enqueue.Count > 1) {
                var item = enqueue.Pop();
                dequeue.Push(item);
            }

            if (enqueue.Count == 1)
            {
                return enqueue.Pop();
            }
            else {
                return dequeue.Pop();
            }
        }

        /// <summary>
        /// 出栈
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            //没有数据
            if (enqueue.Count == 0 && dequeue.Count == 0)
            {
                return -1;
            }

            while (enqueue.Count > 0)
            {
                var item = enqueue.Pop();
                dequeue.Push(item);
            }

            return dequeue.Pop();
        }

        /// <summary>
        /// 进栈
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(int item)
        {
            enqueue.Push(item);
        }

    }

    /// <summary>
    /// 栈和队列:用两个队列实现栈
    /// </summary>
    public class HStack
    {
        /// <summary>
        /// 出栈
        /// </summary>
        private Queue<int> pop;
        /// <summary>
        /// 进栈
        /// </summary>
        private Queue<int> push;

        public HStack()
        {
            pop = new Queue<int>();
            push = new Queue<int>();
        }

        /// <summary>
        /// 出栈
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            //没有数据
            if (push.Count == 0 && pop.Count == 0)
            {
                return -1;
            }

            while (push.Count > 1)
            {
                var item = push.Dequeue();
                pop.Enqueue(item);
            }
            int result = push.Dequeue();

            //数据交换回去
            var temp = pop;
            pop = push;
            push = temp;

            return result;
        }

        /// <summary>
        /// 进栈
        /// </summary>
        /// <param name="item"></param>
        public void Push(int item)
        {
            push.Enqueue(item);
        }
    }
}
