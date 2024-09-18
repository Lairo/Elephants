namespace Elephants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new () { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new() { Name = "Lucinda", EarSize = 33 };
            Elephant swap = new() { Name = "", EarSize = 0 };

            while (true)
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == '1')
                {                    
                    lloyd.WhoAmI(keyChar);
                } else if (keyChar == '2')
                {
                    lucinda.WhoAmI(keyChar);
                }else if (keyChar == '3')
                {
                    swap = lloyd;
                    lloyd = lucinda;
                    lucinda = swap;
                    Console.WriteLine("\nReferences have been swapped.\n");
                }
                else
                {
                    return;
                }

                //Console.WriteLine("Press anything else to quit or make another choice.\n");
            }
        }
    }
}
