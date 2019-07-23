using System;

namespace mylogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's populate word cloud");
            string sentence = "We came, we saw, we conquered...then we ate Bill's (Mille-Feuille) cake.'The bill came to five dollars.'";
            WordCloud wordCloud = new  WordCloud(sentence);
            var cloud = wordCloud.PopulateWordCloud();

            foreach(var item in cloud)
            {
                Console.WriteLine($"{item.Key} appears {item.Value}");
            }

         Console.ReadLine();

        }
    }
}
