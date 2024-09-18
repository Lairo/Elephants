using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephants
{
    internal class Elephant
    {
        public string Name = "";
        public int EarSize;
        

        /// <summary>
        /// The elephant will name itself and give you the size its ears.
        /// "choice" is the number choice inside the loop 1,2,3
        /// </summary>
        /// <param name="choice"> </param>
        public void WhoAmI(char choice)
        {
            Console.WriteLine($"You pressed {choice}");
            Console.WriteLine($"Calling {Name.ToLower()}.WhoAmI()");
            Console.WriteLine($"My name is {Name}.\nMy ears are {EarSize} inches tall.\n");
        }

        internal void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine($"{Name} hear a message");
            Console.WriteLine($"{whoSaidIt.Name} said this: {message}");
        }
    }
}
