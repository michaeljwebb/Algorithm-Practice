//Take both parameters being passed and return the string true if num2 is greater than num1, otherwise return the string false. 
//If the parameter values are equal to each other then return the string -1.
using System;

class MainClass {
  public static int CheckNums(int num1, int num2) { 
    if(num2 > num1){
        Console.WriteLine("true");
    }
    else if(num1 == num2){
        num1 = -1;
    }
    else if(num2 < num1){
        Console.WriteLine("false");
    }
    return num1;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CheckNums(Console.ReadLine()));
    }
}
