//Given an array of integers find the sum of its elements.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int simpleArraySum(int n, int[] ar) {
        int result = 0;
        for(n = 0; n < ar.Length; n++){
            result += ar[n];
        }
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}
