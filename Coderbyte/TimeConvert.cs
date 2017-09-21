using System;

class MainClass {
  public static string TimeConvert(int num) {
    int numHours = num / 60;
    int numMins = num % 60;
    
    return numHours.ToString() + ":" + numMins.ToString();
  }

  static void Main() {
    // keep this function call here
    Console.WriteLine(TimeConvert(Console.ReadLine()));
  } 
   
}
