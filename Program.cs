using System;

namespace Wordle 
{
    class Program 
    {
        static void Main(String[] args) 
        {
            Console.Clear();
            bool guessed = false;
            while (!guessed) 
            {
                var word = new GameWord().GetWord();
                Console.WriteLine("What is your guess?");
                String enteredword = Console.ReadLine();
                while (enteredword.Length != 5)
                {
                    Console.WriteLine("5 letters please.");
                    enteredword = Console.ReadLine();
                }
                int[] correct = {-1, -1, -1, -1, -1};
                for (int i = 0; i < word.Length; i++) 
                {
                    if (word[i] == enteredword[i])
                    {
                        correct[i] = 1;
                    }
                }
                for (int i = 0; i < enteredword.Length; i++)
                {
                    if (word.Contains(enteredword[i]))
                    {
                        correct[i] = 0;
                    }
                }
                String correctstring = "";
                foreach (var number in correct)
                {
                    correctstring += " " + number.ToString();
                }
                Console.WriteLine(correctstring);
            }
        }
    }
}