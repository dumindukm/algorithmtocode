using System;
using System.Collections.Generic;
using System.Linq;

public class WordCloud
{
    private string Word = "";
    private Dictionary<string, int> wordCloud = new Dictionary<string, int>();
    public WordCloud(string word)
    {
        this.Word = word;
    }

    public Dictionary<string, int> PopulateWordCloud()
    {
        string tempTextProgress = string.Empty;
        string[] wordBreakes = new string[]{",",".","'"," "};
        foreach (var item in this.Word.ToCharArray())
        {

            string character = item.ToString().ToLower();
            // need to check if this cause a word break character
            if (wordBreakes.Contains(character))
            {
                if (tempTextProgress.Length==0)
                {
                    continue;
                }
                // add word to dictionary or if already exist increment it's count
                if (wordCloud.ContainsKey(tempTextProgress))
                {
                    wordCloud[tempTextProgress] +=1;
                }
                else
                {
                    wordCloud.Add(tempTextProgress,1);
                }

                tempTextProgress = string.Empty;
            }
            else{
                if (character.Trim() != "")
                {
                    tempTextProgress += character;
                }
                
            }
            
        }


        return wordCloud;
    }
    
}