using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tgnet.Core
{
    public static class StringExtension
    {
        /// <summary>
        /// 返回部分隐藏的字符串
        /// </summary>
        /// <param name="text">要部分隐藏的字符串</param>
        /// <param name="start">从哪里开始隐藏</param>
        /// <param name="paddingChar">替换的字符</param>
        /// <returns></returns>
        public static string Hidden(this string text, int start, char paddingChar = '*')
        {
            if (text == null)
                return text;

            var len = text.Length;
            if (start > len)
                start = 0;
            var limit = len - start;
            return Hidden(text, start, limit, paddingChar);
        }

        /// <summary>
        /// 返回部分隐藏的字符串
        /// </summary>
        /// <param name="text">要部分隐藏的字符串</param>
        /// <param name="start">从哪里开始隐藏</param>
        /// <param name="limit">隐藏的长度，如果原字符长度不够会补足</param>
        /// <param name="paddingChar">替换的字符</param>
        /// <returns></returns>
        public static string Hidden(this string text, int start, int limit, char paddingChar = '*')
        {
            if (text == null)
                return text;

            var len = text.Length;
            if (start > len)
                start = 0;
            var ht = String.Empty.PadLeft(limit, paddingChar);
            if (start + limit > len)
                limit = len - start;
            text = text.Remove(start, limit);
            return text.Insert(start, ht);
        }

        public static string Left(this string text, int length)
        {
            if (text == null)
                return text;

            if (text.Length < length)
                return text;
            else if(length < 0)
            {
                if (text.Length > Math.Abs(length))
                    return text.Left(text.Length + length);
                else
                    return text.Left(-length - text.Length);
            }
            else
            {
                return text.Substring(0, length);
            }
        }

        public static string Right(this string text, int length)
        {
            if (text == null)
                return text;

            if (text.Length < length)
                return text;
            else if(length < 0)
            {
                if (text.Length > Math.Abs(length))
                    return text.Right(text.Length + length);
                else
                    return text.Right(-length - text.Length);
            }
            else
            {
                return text.Substring(text.Length - length, length);
            }
        }

        /// <summary>
        /// 所有参数均为IsNullOrWhiteSpace
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(params string[] strs)
        {
            if(strs != null)
            {
                foreach (var item in strs)
                {
                    if (!String.IsNullOrWhiteSpace(item))
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 所有参数均为IsNullOrEmpty
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(params string[] strs)
        {
            if (strs != null)
            {
                foreach (var item in strs)
                {
                    if (!String.IsNullOrEmpty(item))
                        return false;
                }
            }
            return true;
        }

        private static int[] CharCodeBorders = { 
            45217, 45253, 45761, 46318, 
            46826, 47010, 47297, 47614, 
            48119, 48119, 49062, 49324, 
            49896, 50371, 50614, 50622, 
            50906, 51387, 51446, 52218, 
            52698, 52698, 52698, 52980, 
            53689, 54481, 55290 };

        /// <summary>
        /// 获取拼音首字母
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static char FirstLetter(this char c)
        {
            var bytes = Encoding.Default.GetBytes(new[] { c });
            if (bytes.Length > 1)
            {
                int code = bytes[0] * 256 + bytes[1];
                if (CharCodeBorders[0] <= code && CharCodeBorders[26] > code)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        var min = CharCodeBorders[i];
                        var max = CharCodeBorders[i + 1];
                        if (min <= code && code < max)
                            return Encoding.Default.GetString(new[] { (byte)(97 + i) }).First();
                    }
                }
            }
            return c;
        }

        /// <summary>
        /// 获取第一个字的拼音首字母
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static char FirstLetter(this string s)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(s, "s");
            return FirstLetter(s.First());
        }
    }
}
