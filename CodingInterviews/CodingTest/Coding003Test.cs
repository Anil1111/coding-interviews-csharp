using CodingInterviews;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding003Test
    {
        [Fact]
        public void TestList()
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

        [Fact]
        public void Test()
        {
            ListNode listNode = Coding003.CreateNodeList(10);
            string o = JsonConvert.SerializeObject(listNode);

            List<int> test = Coding003.PrintForStack(listNode);
            string t = JsonConvert.SerializeObject(test);

            List<int> test2 = Coding003.PrintForRecursion(listNode);
            string t2 = JsonConvert.SerializeObject(test2);

            ListNode test3 = Coding003.PrintForReverse(Coding003.PrintForReverse(listNode));
            string t3 = JsonConvert.SerializeObject(test3);

            Assert.Equal(test, test2);
            Assert.Equal(o, t3);
        }

    }
}
