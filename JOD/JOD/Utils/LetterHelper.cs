using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Utils
{
    /// <summary>
    /// 字母对应表
    /// </summary>
    public static class LetterHelper
    {
        private static string[] letter = new string[] {
            "A","B","C","D","E",
            "F","G","H","I","J",
            "K","L","M","N","O",
            "P","Q","R","S","T",
            "U","V","W","X","Y",
            "Z"};
        public static string GetLetter(int index)
        {
            string let = "";
            int s = index / 26;//商
            int y = index % 26;//余数

            if (y == 0)
            {
                if(s <= 1)
                {
                    let = letter[25];
                }
                else
                {
                    if (s <= 26)
                    {
                        let = letter[s - 2];
                    }
                    else
                    {
                        let = GetLetter(s-1);
                    }

                    let += letter[25];
                }
            }
            else
            {
                if (s < 1)
                {
                    //int num = y - 1;
                    //let = letter[num];
                }
                else if (s <= 26)
                {
                    let = letter[s - 1];
                }
                else
                {
                    let = GetLetter(s);
                }

                let += letter[y - 1];
            }
            return let;
        }
    }
}
