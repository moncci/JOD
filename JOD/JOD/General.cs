using JOD.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD
{
    /// <summary>
    /// 通用
    /// </summary>
    public class General
    {
        /// <summary>
        /// 冒号替换量
        /// </summary>
        internal const string CONLON = "_j00998_conlon_j00998_";

        /// <summary>
        /// 获取jod临时工作目录
        /// </summary>
        internal static string tempPath {
            get {
                //获取临时目录路径
                string temp = System.Environment.GetEnvironmentVariable("TEMP");
                DirectoryInfo info = new DirectoryInfo(temp);
                //info.FullName 即是临时目录的路径字符串。
                string dir = Path.Combine(info.FullName, "jod");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                return dir;
            }
        }

        /// <summary>
        /// 清理临时目录
        /// </summary>
        public static void ClearTempPath()
        {
            string dir = tempPath;
            if (Directory.Exists(dir))
            {
                FileHelper.DeleteDir(dir);
            }
        }
        
    }
}
