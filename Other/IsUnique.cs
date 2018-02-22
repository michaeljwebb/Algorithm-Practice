//Determine if string has all unique characters -- return true or false.
using System;
using System.Collections.Generic;

public class Test
{
  public static void Main()
  {
    string test = "Google";
    Console.WriteLine(IsUnique(test));
  }
  
  public static bool IsUnique(string s){
    Dictionary<int,int> uni = new Dictionary<int,int>();
    
    foreach(char c in s){
      if(uni.ContainsKey(c)){
        return false;
      }
      else{
        uni.Add(c,1);
      }
    }  
    return true; 
  }
}
