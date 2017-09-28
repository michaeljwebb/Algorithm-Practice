//Capitalize the first letter of each word.
using System;
using System.Globalization;

class MainClass {
  public static string LetterCapitalize(string str) { 
    
    string cStr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
    str = cStr;
    
    return str;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(LetterCapitalize(Console.ReadLine()));
  } 
}
