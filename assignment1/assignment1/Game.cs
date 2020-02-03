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
            int escape = 1;

            while (escape == 1)
            {
                UI input = new UI();
                input.UserInput();
                input.Story();

                Console.WriteLine("Press '1' to PLAY AGAIN or '2' to QUIT");
                escape = int.Parse(Console.ReadLine());
                Console.Clear();
            } // end while
        }
    }
}
