using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace assignment1
{
    class UI
    {
        string story;
        string adjective;
        string adjective2;
        string noun1;
        string noun2;
        string noun3;
        string verb;
        string liquid;



        public void UserInput()
        {
            Console.WriteLine("Type in an adjective.");
            adjective = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type in another adjective.");
            adjective2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type in a noun.");
            noun1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ok, how about a type of liquid?");
            liquid = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("A noun?");
            noun2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Alright, give me a past tense verb.");
            verb = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Type in a noun.");
            noun3 = Console.ReadLine();
            Console.Clear();

            //Console.WriteLine("That's great. How about entering a type of liquid?");
            //liquid2 = Console.ReadLine();
            //Console.Clear();
        }

        

        public void Story()
        {

            story = "The " + adjective + " " + adjective2 + " " + noun1 + ", went up the " + liquid + " spout.\n Down came the " + noun2 + " and " + verb + " the "
            + noun1 + " out.\n Out came the " + noun3 + " and dried up all the " + liquid +
            "\n And the " + adjective + " " + adjective2 + " " + noun1 + " went up the spout again";

            Console.WriteLine("Creating your story...");
            Thread.Sleep(1000);
            Console.WriteLine("Almost got it....");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("Alright here it is:");
            Console.WriteLine("");

            

            Console.WriteLine(story);

            Console.WriteLine("");
            Console.WriteLine("Press 'ENTER' to continue...");
            Console.ReadLine();
        }
    }


}
