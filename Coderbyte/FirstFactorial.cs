//Take the num parameter being passed and return the factorial of it.﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            Console.WriteLine(FirstFactorial(Int32.Parse((Console.ReadLine()))));
        }
    }
