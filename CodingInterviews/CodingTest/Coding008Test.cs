using CodingInterviews;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding008Test
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, Coding008.Jump(1));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(2, Coding008.Jump(2));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(3, Coding008.Jump(3));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(5, Coding008.Jump(4));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(8, Coding008.Jump(5));
        }

    }
}
