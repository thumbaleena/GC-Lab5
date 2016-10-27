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

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n) ");
            YesNo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many sides does the dice have? ");
            diceSides = int.Parse(Console.ReadLine());
            Console.WriteLine(diceSides + " sided die-");
            Console.WriteLine();

            Random diceRoll1 = new Random();
            int dice1 = diceRoll1.Next(1, diceSides);
            Console.WriteLine("Dice 1: " + dice1);

            Random diceRoll2 = new Random();
            int dice2 = diceRoll2.Next(1, diceSides);
            Console.WriteLine("Dice 2:" + dice2);


        }
    }
}
