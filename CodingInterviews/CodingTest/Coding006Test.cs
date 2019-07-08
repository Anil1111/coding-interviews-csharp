using CodingInterviews;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding006Test
    {
        /// <summary>
        /// 奇数
        /// </summary>
        [Fact]
        public void Test1() {
            int[] array = { 3, 4, 5, 1, 2 };
            Assert.Equal(1, Coding006.MinForBinary(array));
            Assert.Equal(1, Coding006.MinForSimple(array));
        }

        /// <summary>
        /// 偶数
        /// </summary>
        [Fact]
        public void Test2()
        {
            int[] array = { 3, 4, 5, 1 };
            Assert.Equal(1, Coding006.MinForBinary(array));
            Assert.Equal(1, Coding006.MinForSimple(array));
        }

        /// <summary>
        /// 正序
        /// </summary>
        [Fact]
        public void Test3()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Equal(1, Coding006.MinForBinary(array));
            Assert.Equal(1, Coding006.MinForSimple(array));
        }

        /// <summary>
        /// 单数
        /// </summary>
        [Fact]
        public void Test4()
        {
            int[] array = { 1};
            Assert.Equal(1, Coding006.MinForBinary(array));
            Assert.Equal(1, Coding006.MinForSimple(array));
        }

        /// <summary>
        /// 偶数
        /// </summary>
        [Fact]
        public void Test5()
        {
            int[] array = { 1,2 };
            Assert.Equal(1, Coding006.MinForBinary(array));
            Assert.Equal(1, Coding006.MinForSimple(array));
        }

        [Fact]
        public void Test6()
        {
            int[] array = { 2, 1 };
            Assert.Equal(1, Coding006.MinForBinary(array));
            Assert.Equal(1, Coding006.MinForSimple(array));
        }

        [Fact]
        public void Test7()
        {
            int[] array = { 3, 4, 5, 2, 2, 2 };
            Assert.Equal(2, Coding006.MinForBinary(array));
            Assert.Equal(2, Coding006.MinForSimple(array));
        }

        [Fact]
        public void Test8()
        {
            int[] array = { 1, 0, 1, 1, 1 };
            Assert.Equal(0, Coding006.MinForBinary(array));
            Assert.Equal(0, Coding006.MinForSimple(array));
        }
    }
}
