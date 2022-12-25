using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCapitalUtility
{
    public static class ChangeCapitalUtility
    {
        /// <summary>
        /// 使字串大寫的英文字母轉換成底線加小寫字母
        /// 若其大寫字母為第一個字母則不用加底線 
        /// e.g. AppleJuice=>apple_juice
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NoCapital(this string str)
        {
            int len = str.Length;
            string result = string.Empty;

            //先將第一個字母轉為小寫
            result = char.ToLower(str[0]).ToString();

            //再將剩餘字母若是大寫則轉為底線加小寫
            //最後再以迴圈進行拼湊
            for (int i = 1; i < len; i++)
            {
                if ((str)[i] == char.ToLower(str[i]))
                {
                    result += (str)[i].ToString();
                }
                else
                {
                    result += "_" + char.ToLower(str[i]).ToString();
                }
            }

            return result;
        }
    }
}
