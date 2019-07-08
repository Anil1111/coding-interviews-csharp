using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviews
{
    /// <summary>
    /// 查找和排序:旋转数组的最小数字
    /// 把一个数组最开始的若干个元素搬到数组的末尾，我们称之为数组的旋转。 输入一个非减排序的数组的一个旋转，输出旋转数组的最小元素。
    /// 例如数组{3,4,5,1,2}为{1,2,3,4,5}的一个旋转，该数组的最小值为1。 NOTE：给出的所有元素都大于0，若数组大小为0，请返回0。
    /// </summary>
    public class Coding006
    {
        /// <summary>
        /// 旋转数组：给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
        /// 例如数组{3,4,5,1,2}为{1,2,3,4,5}的一个旋转,k为3
        /// 这个方法速度不是很快，还有更快的方法
        /// </summary>
        /// <param name="data"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] Rotate(int[] data, int k)
        {
            if (data == null) return data;
            int temp = 0, length = data.Length;
            k = k % length;
            for (int i = 0; i < k; i++)
            {
                //依次后移
                temp = data[length - 1];
                for (int j = length - 1; j > 0; j--)
                {
                    data[j] = data[j - 1];
                }
                data[0] = temp;
            }

            return data;
        }

        /// <summary>
        /// 旋转数组：给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] Rotate2(int[] nums, int k)
        {
            // 处理 k 大于 数组长度的情况
            k = k % nums.Length;

            // 对前 n - k 个元素 [1,2,3,4] 进行逆转后得到 [4,3,2,1] 
            reverse(nums, 0, nums.Length - 1 - k);
            //对后k个元素 [5,6,7] 进行逆转后得到 [7,6,5]
            reverse(nums, nums.Length - k, nums.Length - 1);
            // 将前后元素 [4,3,2,1,7,6,5] 逆转得到：[5,6,7,1,2,3,4]
            reverse(nums, 0, nums.Length - 1);
            return nums;

            void reverse(int[] nums2, int start, int end)
            {
                while (start < end)
                {
                    int temp = nums2[start];
                    nums2[start++] = nums2[end];
                    nums2[end--] = temp;
                }
            }
        }

        /// <summary>
        /// 最近的方法实现查找最小值
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int MinForSimple(int[] data) {
            if (data == null) return 0;

            int temp = data[0];
            for (int i = 1; i < data.Length; i++) {
                if (data[i] < temp) {
                    temp = data[i];
                }
            }

            return temp;
        }

        /// <summary>
        /// 二分法查找最小值
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int MinForBinary(int[] data)
        {
            if (data == null) return 0;

            int left = 0;
            int right = data.Length - 1;
            var mid = 0;
            while (left < right)
            {
                mid = (left + right) / 2;
                if (data[mid] > data[right]) left = mid + 1;
                else if (data[mid] < data[right]) right = mid;
                else right = mid;
            }

            return data[left];
        }

        /// <summary>
        /// 把一个数组的偶数排在前面奇数排在后面
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] OddAndEven(int[] data) {
            if (data == null) return data;

            int i = 0,j = data.Length - 1;
            for (i = 0; i <= j; i++)
            {
                if (data[i] % 2 == 1)//奇数判断
                {
                    for (int k = j; k > i; k--)
                    {
                        if (data[k] % 2 == 0)//偶数判断
                        {
                            j = k;
                            var temp = data[i];
                            data[i] = data[k];
                            data[k] = temp;
                            break;
                        }
                    }
                }
            }
            
            return data;
        }

    }
}
