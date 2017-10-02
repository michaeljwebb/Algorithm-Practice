//Add up all the numbers from 1 to num.
using System;

class MainClass {
  public static int SimpleAdding(int num) { 
    int result = (num*(num+1))/2;
    num = result;
        
    return num;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(SimpleAdding(Console.ReadLine()));
  } 
} 
