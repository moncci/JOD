using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace JOD.Utils
{
    /// <summary>
    /// 资源帮助类
    /// </summary>
    public class ResourceHelper
    {
        #region 获取模板资源
        /// <summary>
        /// 获取模板资源
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <returns>模板文件</returns>
        public static byte[] GetResource(string name)
        {
            string basePath = string.Format("JOD.Resource.{0}", name);
            Assembly _assembly = Assembly.GetExecutingAssembly();
            using (Stream _stream = _assembly.GetManifestResourceStream(basePath))
            {
                if (_stream == null)
                {
                    return null;
                }
                else
                {
                    byte[] bytes = new byte[_stream.Length];
                    _stream.Read(bytes, 0, bytes.Length);

                    // 设置当前流的位置为流的开始 
                    _stream.Seek(0, SeekOrigin.Begin);
                    return bytes;
                }
            }
        }
        #endregion
    }
}
