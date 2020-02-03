using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup Start = new Setup(); //creates intance of Setup class
            Start.ConsoleSetup(); // Calls method
            Start.Intro();

            Game Play = new Game();
            Play.KeepPlaying();

            Start.Goodbye();
            Thread.Sleep(1000);
        }
    }
}
