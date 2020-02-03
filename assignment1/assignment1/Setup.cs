using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace assignment1
{
    class Setup
    {
        public Setup()
        {
            ConsoleSetup();
        }

        public void ConsoleSetup() // This method adds a title to the window and changes color
                                   // of text and background 
        {
            Console.Title = "Assignment 1 - Word Game";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void Intro()
        {
            Console.WriteLine("This game is just like a version of Mad Libs.");
            Thread.Sleep(2000);
            Console.WriteLine("I will ask you to give me certain types of words and I will create a story for you.");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Are you ready to start?");
            Console.WriteLine("");
            Console.WriteLine("Press 'ENTER' to begin...");

            Console.ReadLine();
            Console.Clear();
        }

        public void Goodbye()
        {
            Console.WriteLine("Thanks for playing!!!");
        }

    }
    
}
