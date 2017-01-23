using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Common
{
    public class PinyinHepler
    {
        public static string GetFirstPinyin(string str)
        {
            string result = string.Empty;
            ChineseChar chineseChar = null;
            string t = "";
            foreach (char obj in str)
            {
                if (!ChineseChar.IsValidChar(obj))
                {
                    result += obj.ToString().ToUpper();
                    continue;
                }
                chineseChar = new ChineseChar(obj);
                t = chineseChar.Pinyins[0].ToString();
                result += t.Substring(0, 1);

            }
            return result;
        }
        public static void test()
        {
            string testString = "st常林";
            var result = GetFirstPinyin(testString);
            Console.WriteLine(result);
        }
    }
}
