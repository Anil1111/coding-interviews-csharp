using CodingInterviews;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class HStack01Test
    {
        [Fact]
        public void Test1()
        {
            HStack hStack = new HStack();
            Stack<int> stack = new Stack<int>();

            hStack.Push(1);
            stack.Push(1);

            hStack.Push(2);
            stack.Push(2);

            hStack.Push(3);
            stack.Push(3);

            Assert.Equal(stack.Pop(), hStack.Pop());
            Assert.Equal(stack.Pop(), hStack.Pop());
            Assert.Equal(stack.Pop(), hStack.Pop());
        }

        [Fact]
        public void Test2()
        {
            HStack hStack = new HStack();
            Stack<int> stack = new Stack<int>();

            hStack.Push(1);
            stack.Push(1);

            hStack.Push(2);
            stack.Push(2);

            Assert.Equal(stack.Pop(), hStack.Pop());
            Assert.Equal(stack.Pop(), hStack.Pop());

            hStack.Push(3);
            stack.Push(3);
            Assert.Equal(stack.Pop(), hStack.Pop());
        }

        [Fact]
        public void Test3()
        {
            HStack hStack = new HStack();
            Stack<int> stack = new Stack<int>();

            hStack.Push(1);
            stack.Push(1);

            Assert.Equal(stack.Pop(), hStack.Pop());
        }

        [Fact]
        public void Test4()
        {
            HStack hStack = new HStack();
            Stack<int> stack = new Stack<int>();

            hStack.Push(1);
            stack.Push(1);

            Assert.Equal(stack.Pop(), hStack.Pop());

            hStack.Push(2);
            stack.Push(2);

            hStack.Push(3);
            stack.Push(3);
            Assert.Equal(stack.Pop(), hStack.Pop());
            Assert.Equal(stack.Pop(), hStack.Pop());
        }
    }
}
