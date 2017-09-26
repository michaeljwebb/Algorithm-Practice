//Convert 12-hour AM/PM time format to military time.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeConversion(string s) {
        DateTime t = DateTime.Parse(s);
        
        return t.ToString("HH:mm:ss");
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
