//Check to see if given string is a palindrome. Return true or false.
using System;
using System.Collections.Generic;

public class Palindrome
{
    public static void Main()
    {
        string testString = "racecar";
        Palindrome(testString);
    }
    
    public static void Palindrome(string s){
        
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
