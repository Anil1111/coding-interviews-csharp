using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterviews
{
    /// <summary>
    /// 字符串替换空格
    /// 请实现一个函数，将一个字符串中的每个空格替换成“%20”。例如，当字符串为We Are Happy.则经过替换之后的字符串为We%20Are%20Happy。
    /// </summary>
    public class Coding002
    {
        /// <summary>
        /// 普通解法，直接替换字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceSpaceForSimple(string str)
        {
            return str.Replace(" ", "%20");
        }

        /// <summary>
        /// 精妙解法数据移位
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceSpace(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (item == ' ')
                {
                    count++;
                }
            }

            int oLength = str.Length;
            int length = oLength + count * 2; //"%20".Length-1
            char[] tempArray = new char[length]; //新开辟了一个空间
            length--;
            for (int i = oLength - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    tempArray[length--] = '0';
                    tempArray[length--] = '2';
                    tempArray[length--] = '%';
                }
                else
                {
                    tempArray[length--] = str[i];
                }
            }

            return new string(tempArray);
        }

        /// <summary>
        /// 赋值给另外一个
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceForBS(string str) {
            StringBuilder sb = new StringBuilder();
            foreach (var item in str) {
                if (item == ' ')
                {
                    sb.Append("%20");
                }
                else {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }

    }
}
