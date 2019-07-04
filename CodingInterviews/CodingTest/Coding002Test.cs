using CodingInterviews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace CodingTest
{
    public class Coding002Test
    {
        /// <summary>
        /// 中间空格
        /// </summary>
        [Fact]
        public void Middle()
        {
            string str = "We Are Happy.";
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceSpace(str));
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceForBS(str));
        }

        /// <summary>
        /// 开始空格
        /// </summary>
        [Fact]
        public void Start()
        {
            string str = " We Are Happy.";
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceSpace(str));
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceForBS(str));
        }

        /// <summary>
        /// 结束空格
        /// </summary>
        [Fact]
        public void End()
        {
            string str = "We Are Happy. ";
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceSpace(str));
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceForBS(str));
        }

        /// <summary>
        /// 多空格
        /// </summary>
        [Fact]
        public void More()
        {
            string str = "We     Are  Happy.";
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceSpace(str));
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceForBS(str));
        }

        /// <summary>
        /// 空字符串
        /// </summary>
        [Fact]
        public void Empty()
        {
            string str = "";
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceSpace(str));
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceForBS(str));

            str = " ";
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceSpace(str));
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceForBS(str));

            str = "  ";
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceSpace(str));
            Assert.Equal(Coding002.ReplaceSpaceForSimple(str), Coding002.ReplaceForBS(str));
        }
    }
}
