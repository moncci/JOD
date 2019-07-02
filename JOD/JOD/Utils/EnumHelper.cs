using JOD.Writer.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Utils
{
    /// <summary>
    /// 枚举帮助类
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 枚举转为字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string EnumConvertToString<T>(this T t) where T : Enum
        {
            //方法一
            //return color.ToString();

            //方法二
            return Enum.GetName(t.GetType(), t);
        }


        /// <summary>
        /// 字符串转为枚举
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool StringConvertToEnum<T>(this string str, out T t) where T : Enum
        {
            T color;
            try
            {
                color = (T)Enum.Parse(typeof(T), str);
                t = color;
                return true;
            }
            catch (Exception ex)
            {
                t = default(T);
                return false;
            }
        }
    }
}
