//Count number of words in a string.
//Not Complete
using System;

public class Test
{
  public static void Main()
  {
    string test = "Hello there how are you?";
    Console.WriteLine(CountWords(test));
  }
  
  public static int CountWords(string x){
    
    int result = 0;
    x = x.Trim();
    
    if(x == ""){
      return 0;
    }
    
    while(x.Contains(" ")){
      x = x.Replace(" ", "");
    }
    
    foreach(string y in x.Split(' ')){
      result++;
    }
    return result;
  }
}
