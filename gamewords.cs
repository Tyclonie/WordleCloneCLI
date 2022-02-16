using System;
using System.Net;

namespace Wordle
{
    public class GameWord
    {
        private String word;
        public GameWord()
        {
            this.word = RequestWords();
        }
        private String RequestWords() 
        {
            WebRequest request = WebRequest.Create("https://random-word-api.herokuapp.com/word?number=10");
            Stream response = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(response);
            return CheckWords(reader.ReadLine().Replace("[\"","").Replace("\"]","").Split("\",\""));
        }
        private String CheckWords(String[] words)  
        {
            String tempword;
            foreach (String word in words) 
            {
                if (word.Length == 5)
                {
                    tempword = word;
                    return tempword;
                }
            }
            return RequestWords();
        }
    }
}