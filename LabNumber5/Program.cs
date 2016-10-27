using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            string YesNo;
            int diceSides;
            int dice1;
            int dice2;

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n) ");
            YesNo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many sides does the dice have? ");
            diceSides = int.Parse(Console.ReadLine());
            Console.WriteLine(diceSides + " sided die-");
            Console.WriteLine();

            RollDice(diceSides);
            dice1 = diceResult;

        }

        private static void RollDice(int diceSides)
        {
            Random diceRoll = new Random();
            int diceResult = diceRoll.Next(1, diceSides);
            int result = diceResult;
        }
    }
}
