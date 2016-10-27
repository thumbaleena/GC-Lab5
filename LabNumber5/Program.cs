using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber5
{
    class DiceRollerApp
    {
        static void Main(string[] args)
        {
            string YesNo, Continue = "yes";
            int input;

            YesNo = Initialize();

            while (Continue == "yes" || Continue == "y")
            {
                input = RollTheDice();
                Continue = RollAgain();
            }
        }

        private static string RollAgain()
        {
            string Continue;
            Console.WriteLine();
            Console.WriteLine("Roll again?");
            Continue = Console.ReadLine();
            while (Continue.ToLower() != "yes" && Continue.ToLower() != "y" && Continue.ToLower() != "no" && Continue.ToLower() != "n")
            {
                Console.Write("Invalid entry. Try again! "); //input validation since there are only 2 right answers
                Continue = Console.ReadLine();
            }
            if (Continue == "no" || Continue == "n" || Continue == "N" || Continue == "No")
            { Environment.Exit(0); }
            Console.WriteLine();
            Console.WriteLine();
            return Continue;
        }

        private static int RollTheDice()
        {
            int input;
            Console.WriteLine("How many sides does the dice have? ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Random diceRoll1 = new Random((Int32)DateTime.Now.Ticks);
            int dice1 = diceRoll1.Next(1, input);
            Console.WriteLine("Dice 1: " + dice1);

            Random diceRoll2 = new Random((Int32)DateTime.Now.Ticks);
            int dice2 = diceRoll2.Next(1, input);
            Console.WriteLine("Dice 2: " + dice2);
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else (dice1 == 6 && dice2 == 6)
                    {
                Console.WriteLine("You got whatever 2 sixes is!");
            }
            return input;
        }

        private static string Initialize()
        {
            string YesNo;
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n) ");
            YesNo = Console.ReadLine();
            while (YesNo.ToLower() != "yes" && YesNo.ToLower() != "y" && YesNo.ToLower() != "no" && YesNo.ToLower() != "n")
            {
                Console.Write("Invalid entry. Try again! "); //input validation since there are only 2 right answers
                YesNo = Console.ReadLine();
            }
            if (YesNo == "n")
            { Environment.Exit(0); }
            Console.WriteLine();
            return YesNo;
        }
    }
}
