using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverseString
    {
        public string Reverse_String(string s)
        {

            char[] sArray = s.ToCharArray();
            string result = "";
            for (int i = sArray.Length - 1; i >= 0; i--)
            {
                result += sArray[i];
                s = result;

            }
            return s;

        }

    }
}
