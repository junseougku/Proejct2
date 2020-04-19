using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Project3
{
    //전역클래스
    static class GlobalClass
    {
        //두 문자열을 int값으로 계산후 더한다음 다시문자열로 리턴
        public static string Get_Sum_StringToIntValue(string str1,string str2)
        {
            if(int.TryParse(str1, out int tempInt1) == false) return "false";
            if(int.TryParse(str2, out int tempInt2) == false) return "false";
            tempInt1 = tempInt1 + tempInt2;

            return tempInt1.ToString();
        }

        //문자열에서 숫자이외의 값은 없애버리고 리턴
        public static string Get_ValidatedCheckInt(string str1)
        {
            str1 = Regex.Replace(str1, @"[^0-9]", "");

            return str1;
        }
    }
}
