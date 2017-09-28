//Capitalize(first letter) the first word in a title.
//Capitalize(first letter) the last word in a title.
//Lowercase the following words unless they are first or last word of the title: "a", "the", "to", "at", "in", "with", "and", "but", "or"
//Capitalize(first letter) any words not in the list above.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TitleCapitalization
{
  private List<string> lowerList = new List<string>
                                        {
                                        "a","the","to","at","in","with","and","but","or"
                                        };
	
  public void Main(){
  	string testTitle = "These are the days of our lives";
  	TitleCase(testTitle);
  	Console.WriteLine(TitleCase(testTitle));
  }

  public string TitleCase(string title){
  //Lowercase title
  title = title.ToLower();
	
  //Split title by spaces
  var words = title.Split(' ');

  //Loop through words
  for(int i = 0; i < words.Length; i++)
  {
    //If words are first or last word or are not in lowerList then capitalize word.
	  if(i == 0 || i == words.Length - 1 || !lowerList.Contains(words[i])){
		words[i] = Capitalize(words[i]);
	  }
  }
  //Combine words
  return string.Join(" ", words);
  }
  
  public string Capitalize(string word)
  {
    word = char.ToUpper(word[0]) + word.Substring(1);
    return word;
  }
}
