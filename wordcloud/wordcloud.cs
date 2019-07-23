using System.Collections.Generic;

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
        foreach (var item in this.Word.ToCharArray())
        {
            
        }


        return wordCloud;
    }
    
}