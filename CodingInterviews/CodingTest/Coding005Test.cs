using CodingInterviews;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding005Test
    {
        [Fact]
        public void Test1()
        {
            Coding005 coding005 = new Coding005();
            Queue<int> queue = new Queue<int>();

            coding005.Enqueue(1);
            queue.Enqueue(1);

            coding005.Enqueue(2);
            queue.Enqueue(2);

            coding005.Enqueue(3);
            queue.Enqueue(3);

            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
        }

        [Fact]
        public void Test2()
        {
            Coding005 coding005 = new Coding005();
            Queue<int> queue = new Queue<int>();

            coding005.Enqueue(1);
            queue.Enqueue(1);

            coding005.Enqueue(2);
            queue.Enqueue(2);

            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
            Assert.Equal(queue.Dequeue(), coding005.Dequeue());

            coding005.Enqueue(3);
            queue.Enqueue(3);
            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
        }

        [Fact]
        public void Test3()
        {
            Coding005 coding005 = new Coding005();
            Queue<int> queue = new Queue<int>();

            coding005.Enqueue(1);
            queue.Enqueue(1);

            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
        }

        [Fact]
        public void Test4()
        {
            Coding005 coding005 = new Coding005();
            Queue<int> queue = new Queue<int>();

            coding005.Enqueue(1);
            queue.Enqueue(1);

            Assert.Equal(queue.Dequeue(), coding005.Dequeue());

            coding005.Enqueue(2);
            queue.Enqueue(2);

            coding005.Enqueue(3);
            queue.Enqueue(3);
            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
            Assert.Equal(queue.Dequeue(), coding005.Dequeue());
        }
    }
}
