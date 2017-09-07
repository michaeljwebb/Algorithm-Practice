using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class FizzBuzz
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i < 16; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
