using CodingInterviews;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding003Test
    {
        [Fact]
        public void Test()
        {
            ListNode listNode = Coding003.CreateNodeList(10);
            List<int> test = Coding003.PrintForStack(listNode);
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(i, test[9 - i]);
            }

            List<int> test2 = Coding003.PrintForRecursion(listNode);
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(i, test2[9 - i]);
            }
        }
    }
}
