using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviews
{
    /// <summary>
    /// 在一个二维数组中（每个一维数组的长度相同），每一行都按照从左到右递增的顺序排序，每一列都按照从上到下递增的顺序排序。
    /// 请完成一个函数，输入这样的一个二维数组和一个整数，判断数组中是否含有该整数。
    /// </summary>
    public class Coding001
    {
        /// <summary>
        /// 暴力解法-直接遍历
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="target">目标</param>
        /// <returns></returns>
        public static bool FindForSimple(int[,] array, int target)
        {
            bool result = false;
            if (CheckIsArrayRange(array, target))
            {
                foreach (var item in array)
                {
                    if (target == item)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 右上角解题
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool FindForRight(int[,] array, int target)
        {
            bool result = false;

            if (CheckIsArrayRange(array, target))
            {
                int rowLength = array.GetLength(0);
                int colLength = array.GetLength(1);

                int row = 0, col = colLength - 1;//坐标右上角
                while (row < rowLength && col >= 0)
                {
                    if (array[row, col] == target)
                    {
                        result = true;
                        break;
                    }
                    else if (array[row, col] > target)
                    {
                        col--;
                    }
                    else
                    {
                        row++;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 等比数列的数组
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool FindForN(int[,] array, int target)
        {
            bool result = false;
            if (CheckIsArrayRange(array, target))
            {
                int rowLength = array.GetLength(0);
                int colLength = array.GetLength(1);
                int first = array[0, 0];
                int second = 0;

                if (rowLength > 1) { second = array[1, 0]; }
                else if (colLength > 1) { second = array[0, 1]; }
                else { second = target; }

                int n = second - first;
                if (n == 0)
                {
                    if (first == target)
                    {
                        result = true;
                    }
                }
                else
                {
                    int remainder = (target - first) % n;
                    if (remainder == 0)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 检测是否在数组范围内
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private static bool CheckIsArrayRange(int[,] array, int target)
        {
            bool result = false;
            if (array != null && array.Rank == 2)
            {
                int rowLength = array.GetLength(0);
                int colLength = array.GetLength(1);
                int start = array[0, 0];
                int end = array[rowLength - 1, colLength - 1];
                if (start <= target && target <= end)
                {
                    result = true;
                }
            }
            return result;
        }

        public static void Test()
        {
            //int[,] array = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };
            //int[,] array = { { 1, 3, 5, 7 }, { 3, 5, 7, 9 }, { 5, 7, 9, 11 } };
            int[,] array = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            int target = 4;
            Console.WriteLine($"{FindForSimple(array, target)},{FindForRight(array, target)}");
        }

    }
}
