using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Game
    {
        public void KeepPlaying()
        {
            int playAgain = 1;
            // while loop to keep game going until user decides to quit
            while (playAgain == 1)
            {
                UI input = new UI();
                input.UserInput();
                input.Story();

                Console.WriteLine("Press '1' to PLAY AGAIN or '2' to QUIT");
                playAgain = int.Parse(Console.ReadLine());
                Console.Clear();
            } // end while
        }
    }
}
