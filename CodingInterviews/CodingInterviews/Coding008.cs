using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviews
{
    /// <summary>
    /// 递归和循环:跳台阶
    /// 一只青蛙一次可以跳上1级台阶，也可以跳上2级。求该青蛙跳上一个n级的台阶总共有多少种跳法（先后次序不同算不同的结果）。
    /// </summary>
    public class Coding008
    {
        /// <summary>
        /// 循环跳台阶
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Jump(int n) {
            if (n <= 2) {
                return n;
            }

            int first = 1;
            int second = 2;
            int result = 0;
            for (int i = 3; i <= n; i++) {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }
    }
}
