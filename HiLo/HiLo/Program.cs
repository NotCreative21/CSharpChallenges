using System;

namespace HiLo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hilo");
            Console.WriteLine("I'm thinking of a number in the range [1, 100].");
            Console.WriteLine("Can you guess it?");

            Console.WriteLine("Choose difficulty:");
            Console.WriteLine("(1) Easy (8 Guesses)");
            Console.WriteLine("(2) Medium (7 Guesses)");
            Console.WriteLine("(3) Hard (6 Guesses)");

            Random random = new Random();

            int number = random.Next(1, 100);
            int guesslimit = 0;
            int gamemode = Convert.ToInt32(Console.ReadLine());
            switch (gamemode) {
                case 1:
                    Console.WriteLine("You chose: (1) Easy (8 Guesses)");
                    guesslimit = 7;
                    break;
                case 2:
                    Console.WriteLine("You chose: (2) Medium (7 Guesses)");
                    guesslimit = 6;
                    break;
                case 3:
                    Console.WriteLine("You chose: (3) Hard (6 Guesses)");
                    guesslimit = 5;
                    break;
                default:
                    Console.WriteLine("Please state a valid gamemode");
                    break;
            }
            while (guesslimit != 0)
            {
                Console.WriteLine("What's your guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("I chose the number " + number);
                    Console.WriteLine("~~ Victory ~~");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower!");
                    Console.WriteLine("Remaining guesses: " + guesslimit);
                    guesslimit--;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher!");
                    Console.WriteLine("Remaining guesses: " + guesslimit);
                    guesslimit--;
                }
            }

            Console.WriteLine("I chose the number " + number);
            Console.WriteLine("-- Defeat --");

        }
    }
}
