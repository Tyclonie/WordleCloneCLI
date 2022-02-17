using System;

namespace Wordle 
{
    class Program 
    {
        static void Main(String[] args) 
        {
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.White;
            var word = new GameWord().GetWord();
            String[] enteredwords = {"none", "none", "none", "none", "none"};
            int[] correct = {-1, -1, -1, -1, -1};
            bool guessed = false;
            int loops = 0;
            while (!guessed && loops < 5) 
            {
                Console.WriteLine("What is your guess?");
                enteredwords[loops] = Console.ReadLine();
                while (enteredwords[loops].Length != 5)
                {
                    Console.WriteLine("5 letters please.");
                    enteredwords[loops] = Console.ReadLine();
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var enteredword in enteredwords) 
                {
                    if (enteredword != "none") 
                    {
                        for (int i = 0; i < enteredword.Length; i++) 
                        {
                            if (word.Contains(enteredword[i]))
                            {
                                correct[i] = 0;
                            }
                            if (word[i] == enteredword[i])
                            {
                                correct[i] = 1;
                            }
                        }
                        for (int i = 0; i < enteredword.Length; i++) 
                        {
                            if (correct[i] == 1)
                            {
                                Console.ForegroundColor=ConsoleColor.DarkGreen;
                                Console.Write(enteredword[i]);
                            }
                            else if (correct[i] == 0)
                            {
                                Console.ForegroundColor=ConsoleColor.DarkYellow;
                                Console.Write(enteredword[i]);
                            }
                            else
                            {
                                Console.ForegroundColor=ConsoleColor.White;
                                Console.Write(enteredword[i]);
                            }
                        }
                        Console.ForegroundColor=ConsoleColor.White;
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("");
                if (enteredwords[loops] == word)
                {
                    guessed = true;
                }
                loops++;
            }
            if (guessed)
            {
                Console.WriteLine("Well done! The word was " + word);
            }
            else 
            {
                Console.WriteLine("Unlucky! The word was " + word);
            }
        }
    }
}