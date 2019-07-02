using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Utils
{
    /// <summary>
    /// 文件帮助类
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// 写入xml文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="xml">xml内容</param>
        /// <returns></returns>
        public static bool WriteXmlFle(string filePath, string xml)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);
            sw.Write(xml);
            sw.Close();
            return true;
        }

        #region 直接删除指定目录下的所有文件及文件夹(保留目录)

        /// <summary>
        ///直接删除指定目录下的所有文件及文件夹(保留目录)
        /// </summary>
        /// <param name="strPath">文件夹路径</param>
        /// <returns>执行结果</returns>

        public static void DeleteDir(string file)
        {
            //去除文件夹和子文件的只读属性
            //去除文件夹的只读属性
            System.IO.DirectoryInfo fileInfo = new DirectoryInfo(file);
            fileInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;

            //去除文件的只读属性
            System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal);

            //判断文件夹是否还存在
            if (Directory.Exists(file))
            {
                foreach (string f in Directory.GetFileSystemEntries(file))
                {
                    if (File.Exists(f))
                    {
                        //如果有子文件删除文件
                        File.Delete(f);
                        Console.WriteLine(f);
                    }
                    else
                    {
                        //循环递归删除子文件夹
                        DeleteDir(f);
                    }
                }

                //删除空文件夹
                Directory.Delete(file);
            }
        }

        #endregion
    }
}
