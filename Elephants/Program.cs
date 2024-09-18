namespace Elephants
{
    internal class Program
    {
        static void Main()
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33};
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 33 };
            elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };

            Elephant biggestEars = elephants[0];

            for(int i = 1; i < elephants.Length; i++)
            {
                Console.WriteLine($"Iteration #{i}");

                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }

                Console.WriteLine(biggestEars.EarSize.ToString());
            }


            //Elephant lloyd = new() { Name = "Lloyd", EarSize = 40 };
            //Elephant lucinda = new() { Name = "Lucinda", EarSize = 33 };
            //Elephant swap = new();

            //bool[] myArray = new bool[15];
            //myArray[4] = false;

            //while (true)
            //{
            //    Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            //    char keyChar = Console.ReadKey(true).KeyChar;
            //    if (keyChar == '1')
            //    {                    
            //        lloyd.WhoAmI(keyChar);
            //    } else if (keyChar == '2')
            //    {
            //        lucinda.WhoAmI(keyChar);
            //    }else if (keyChar == '3')
            //    {
            //        swap = lloyd;
            //        lloyd = lucinda;
            //        lucinda = swap;
            //        Console.WriteLine("\nReferences have been swapped.\n");
            //    } else if (keyChar == '4')
            //    {
            //        lloyd = lucinda;
            //        lloyd.EarSize = 4321;
            //        lloyd.WhoAmI(keyChar);
            //    } else if (keyChar == '5')
            //    {
            //        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
            //    }
            //    else
            //    {
            //        return;
            //    }

                //Console.WriteLine("Press anything else to quit or make another choice.\n");
            //}
        }
    }
}
