//Check to see if given string is a palindrome. Return true or false.
//Not completed

using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        string testString = "racecar";
        Palindrome(testString);
    }
    
    public static string Palindrome(string s){
        
        Dictionary<int,int> _pCount = new Dictionary<int,int>();
        int isOdd = 0;
        char[] cArray = s.ToCharArray();
        
        for(int i = 0; i < cArray.Length; i++){
            
            if(!_pCount.ContainsKey(cArray[i])){
                _pCount.Add(cArray[i], 1);
            }
            else{
                int tempCount = _pCount[cArray[i]];
                tempCount++;
                
                if(tempCount % 1 == 0){
                    isOdd++;
                }
                
                if(isOdd > 1){
                    Console.WriteLine(isOdd + " false");
                }
                
                else if(isOdd <= 1){
                    Console.WriteLine(isOdd + " true");
                }
            }
        }
        return isOdd.ToString();
    }
}
