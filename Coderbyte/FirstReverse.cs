using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte
{
    class FirstReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine(First_Reverse(Console.ReadLine()));
        }
        
        public static string First_Reverse(string str)
        {
            char[] cArray = str.ToCharArray();
            string result = "";
            for (int i = cArray.Length - 1; i >= 0; i--)
            {
                result += cArray[i];
                str = result;
            }
            return str;
        }
    }
}
