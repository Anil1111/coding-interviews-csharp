using CodingInterviews;
using System;
using Xunit;

namespace CodingTest
{
    public class Coding001Test
    {
        [Fact]
        public void Test1()
        {
            int[,] array = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            int target = 4;
            Assert.True(Coding001.FindForSimple(array, target));
            Assert.True(Coding001.FindForRight(array, target));
        }

        [Fact]
        public void Test3()
        {
            int[,] array = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            int target = 3;
            Assert.False(Coding001.FindForSimple(array, target));
            Assert.False(Coding001.FindForRight(array, target));
        }

        [Fact]
        public void MinTest()
        {
            int[,] array = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            int target = 0;
            Assert.False(Coding001.FindForSimple(array, target));
            Assert.False(Coding001.FindForRight(array, target));
        }


        [Fact]
        public void MaxText()
        {
            int[,] array = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            int target = 16;
            Assert.False(Coding001.FindForSimple(array, target));
            Assert.False(Coding001.FindForRight(array, target));
        }

        [Fact]
        public void Test5()
        {
            int[,] array = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };
            int target = 3;
            Assert.True(Coding001.FindForSimple(array, target));
            Assert.True(Coding001.FindForRight(array, target));
            Assert.True(Coding001.FindForN(array, target));
        }

        [Fact]
        public void Test6()
        {
            int[,] array = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };
            int target = 7;
            Assert.False(Coding001.FindForSimple(array, target));
            Assert.False(Coding001.FindForRight(array, target));
            Assert.False(Coding001.FindForN(array, target));
        }

        [Fact]
        public void Test7()
        {
            int[,] array = { { 1, 3, 5, 7 }, { 3, 5, 7, 9 }, { 5, 7, 9, 11 } };
            int target = 9;
            Assert.True(Coding001.FindForSimple(array, target));
            Assert.True(Coding001.FindForRight(array, target));
            Assert.True(Coding001.FindForN(array, target));
        }

        [Fact]
        public void Test8()
        {
            int[,] array = { { 1, 3, 5, 7 }, { 3, 5, 7, 9 }, { 5, 7, 9, 11 } };
            int target = 8;
            Assert.False(Coding001.FindForSimple(array, target));
            Assert.False(Coding001.FindForRight(array, target));
            Assert.False(Coding001.FindForN(array, target));
        }

    }
}
