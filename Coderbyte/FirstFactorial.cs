﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coderbyte
{
    class MainClass
    {
        public static int FirstFactorial(int num)
        {
            int fact = num;
            for (int i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
                num = fact;
            }
            return num;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(FirstFactorial(Console.ReadLine()));
        }
    }
}
