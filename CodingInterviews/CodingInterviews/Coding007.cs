using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviews
{
    /// <summary>
    /// 递归和循环:斐波那契数列
    /// 大家都知道斐波那契数列，现在要求输入一个整数n，请你输出斐波那契数列的第n项（从0开始，第0项为0）。 n<=39
    /// </summary>
    public class Coding007
    {
        /// <summary>
        /// 递归实现
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci(int n) {
            if (n <= 1) return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// 循环实现
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci2(int n)
        {
            if (n <= 1) return n;

            int first = 0;
            int second = 1;
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }

        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibonacciSum(int n) {
            if (n <= 1) return n;
            int first = 0;
            int second = 1;
            int temp = 0;
            int result = first + second;
            for (int i = 2; i <= n; i++) {
                temp = first + second;
                first = second;
                second = temp;

                result = result + temp;
            }

            return result;
        }

        /// <summary>
        /// 利用公式求和
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibonacciSum2(int n)
        {
            if (n <= 1) return n;
            int first = 0;
            int second = 1;
            int temp = 0;
            for (int i = 2; i <= n; i++)
            {
                temp = first + second;
                first = second;
                second = temp;
            }

            int result = 2 * second + first - 1; //Sn = 2an + an - 1 - 1

            return result;
        }
    }
}
