//Check to see if given string is a palindrome. Return true or false. Ignore letter casing.
using System;
using System.Collections.Generic;

public class Palindrome
{
  public static bool Palindrome(string word)
  {
    string result = "";
    bool flag = false;
    string lowerWord = word.ToLower();

    for(int i = lowerWord.Length - 1; i >= 0; i--)
    {
      result += lowerWord[i];
    }

    if(result == lowerWord)
    {
      flag = true;
    }
    else
    {
      flag = false;
    }
    return flag;
  }

	public static void Main()
	{
    Console.WriteLine(Palindrome("interview"));
    Console.WriteLine(Palindrome("racecar"));
    Console.WriteLine(Palindrome("Racecar"));
	}
}
