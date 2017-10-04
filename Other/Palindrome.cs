//Check to see if given string is a palindrome. Return true or false.
using System;
using System.Collections.Generic;

public class Palindrome
{
    public static void Main()
    {
        string testString = "racecar";
        CheckPalindrome(testString);
    }
    
    public static void CheckPalindrome(string s){
        
        string result = "";
        char[] cArray = s.ToCharArray();
        
        for(int i = cArray.Length - 1; i >= 0; i--){
            result += cArray[i];
        }
        if(result == s){
            Console.WriteLine(result + " true");   
        }
        else if(result != s){
            Console.WriteLine(result + " false");
        }
    }
}
