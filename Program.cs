using System;

namespace Wordle 
{
    class Program 
    {
        static void Main(String[] args) 
        {
            var game = new Game("hello");
            Console.WriteLine(game.word);
        }
    }
}