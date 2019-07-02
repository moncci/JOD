using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Utils
{
    public  static class CmRelHelper
    {
        public const double REL = 566.8887320109594;

        /// <summary>
        /// 厘米转为rel
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public static int CmToRel(double cm)
        {
            double rel = cm * REL;
            int result = (int)Math.Round(rel, 0);
            return result;
        }

        /// <summary>
        /// rel转为厘米
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public static double RelCm(double rel)
        {
            double cm = rel / REL;
            double result = (double)Math.Round(rel, 3);
            return result;
        }
    }
}
