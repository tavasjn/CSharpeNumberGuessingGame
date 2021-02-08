using System;

namespace NumberGuessingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number between 0 - 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("To High! Go Lower");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("To low, Go Higher");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You Win");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
