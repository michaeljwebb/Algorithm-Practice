//Each letter in the string must be surrounded by a +. Return true or false.
//Not completed
using System;
using System.Text.RegularExpressions;

class MainClass {
  public static string SimpleSymbols(string str) {
  
    char[] cArray = str.ToCharArray();
    
    for(int i = 0; i < cArray.Length; i++){
        if("+" + Regex.IsMatch(cArray[i].ToString(), @"^[a-zA-Z]+$").ToString() + "+"){
            Console.WriteLine("true");
        }
    }
    return str;
  }

  static void Main() {
    // keep this function call here
    Console.WriteLine(SimpleSymbols(Console.ReadLine()));
  } 
}
