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

        public void WhoAmI(char choice)
        {
            Console.WriteLine($"You pressed {choice}");
            Console.WriteLine($"Calling {Name.ToLower()}.WhoAmI()");
            Console.WriteLine($"My name is {Name}.\nMy ears are {EarSize} inches tall.\n");
        }
    }
}
