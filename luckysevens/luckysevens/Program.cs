using System;
using System.Runtime;

namespace luckysevens
{
    class Program
    {
        static void Main(string[] args)
        {
            int roll = 0;
            Console.WriteLine("Welcome to Lucky Sevens!");
            Console.Write("Please enter a starting amount of money: $");
            double startcash = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("starting cash: $" + startcash);
            while (startcash > 0)
            {
                Console.Write("Please place a bet: $");
                double betd = Convert.ToDouble(Console.ReadLine());
                if (betd > 0 && betd <= startcash)
                {
                    Console.WriteLine("You bet: $" + betd);
                    if (betd < startcash)
                    {
                        roll++;
                        System.Random random = new System.Random();
                        var dice1 = random.Next(1, 7);
                        var dice2 = random.Next(1, 7);
                        System.Console.Write("[" + dice1 + "]");
                        System.Console.WriteLine("[" + dice2 + "]");
                        if (dice1 + dice2 == 7)
                        {
                            Console.WriteLine("~~ Lucky Sevens! ~~");
                            Console.WriteLine("You win: $" + (betd * 5));
                            double win = betd * 5;
                            startcash = win + startcash;
                        }
                        //reroll
                        else if (dice1 == dice2 && dice1 + dice2 != 7)
                        {
                            Console.WriteLine("~ Reroll ~");
                            Console.WriteLine("You win: $" + betd);
                            Console.WriteLine("Monkey: $" + startcash);
                            roll++;
                        }
                        else
                        {
                            startcash = startcash - betd;
                            Console.WriteLine("Monkey: $" + startcash);
                        }
                        Console.WriteLine("Do you wish to keep playing? (0) No (1) Yes:");
                        int keepplay = Convert.ToInt32(Console.ReadLine());
                        if (keepplay == 0)
                        {
                            Console.WriteLine("Thanks for playing!");
                            Console.WriteLine("You quit after " + roll + " rolls!");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                    }
                    else
                    {
                        Console.WriteLine("You went broke after " + roll + " rolls!");
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid bet: $" + betd);
                }

            }
        }
    }
}
