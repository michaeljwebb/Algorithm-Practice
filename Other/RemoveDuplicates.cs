//Remove duplicates from given string
using System;

public class Test
{
  public static void Main()
  { 
    string testValue = "Google";
    Console.WriteLine(RemoveDuplicateChars(testValue));
  }
  
  public static string RemoveDuplicateChars(string key){
    string table = "";
    string result = "";
    
    foreach(char value in key){
      if (table.IndexOf(value) == -1){
        table += value;
        result += value;
      }
    }
    return result;
  }
}
