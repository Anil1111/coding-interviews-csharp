using CodingInterviews;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding007Test
    {
        [Fact]
        public void Test0()
        {
            Assert.Equal(0, Coding007.Fibonacci(0));
            Assert.Equal(0, Coding007.Fibonacci2(0));
            Assert.Equal(0, Coding007.FibonacciSum(0));
            Assert.Equal(0, Coding007.FibonacciSum2(0));
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(1, Coding007.Fibonacci(1));
            Assert.Equal(1, Coding007.Fibonacci2(1));
            Assert.Equal(1, Coding007.FibonacciSum(1));
            Assert.Equal(1, Coding007.FibonacciSum2(1));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1, Coding007.Fibonacci(2));
            Assert.Equal(1, Coding007.Fibonacci2(2));
            Assert.Equal(2, Coding007.FibonacciSum(2));
            Assert.Equal(2, Coding007.FibonacciSum2(2));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(2, Coding007.Fibonacci(3));
            Assert.Equal(2, Coding007.Fibonacci2(3));
            Assert.Equal(4, Coding007.FibonacciSum(3));
            Assert.Equal(4, Coding007.FibonacciSum2(3));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(3, Coding007.Fibonacci(4));
            Assert.Equal(3, Coding007.Fibonacci2(4));
            Assert.Equal(7, Coding007.FibonacciSum(4));
            Assert.Equal(7, Coding007.FibonacciSum2(4));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(5, Coding007.Fibonacci(5));
            Assert.Equal(5, Coding007.Fibonacci2(5));
            Assert.Equal(12, Coding007.FibonacciSum(5));
            Assert.Equal(12, Coding007.FibonacciSum2(5));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(8, Coding007.Fibonacci(6));
            Assert.Equal(8, Coding007.Fibonacci2(6));
            Assert.Equal(20, Coding007.FibonacciSum(6));
            Assert.Equal(20, Coding007.FibonacciSum2(6));
        }

    }
}
