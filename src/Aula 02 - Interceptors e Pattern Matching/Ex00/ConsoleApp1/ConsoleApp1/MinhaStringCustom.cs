using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MinhaStringCustom
    {
        public static string CustomMethod(this string str)
        {
            return $"Custom: {str}";
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static string Truncate(this string str, int max)
        {
            if (string.IsNullOrEmpty(str) || str.Length >= max) 
            {
                return str.Substring(0, max);
            }

            return str;
        }

        public static bool IsAscii(this char str)
        {
            return str <= 0x7F;
        }

    }
}
