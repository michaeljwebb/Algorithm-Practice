//Take the str string parameter being passed and return the string with the letters in alphabetical order.
using System;

class MainClass {
  public static string AlphabetSoup(string str) { 
  
    char[] cArray = str.ToCharArray();
    Array.Sort<char>(cArray);
    string result = "";
    
    for(int i = 0; i < cArray.Length; i++){
        result += cArray[i];
        str = result;
    }
    return str;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(AlphabetSoup(Console.ReadLine()));
  } 
} 
