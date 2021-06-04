using System;

namespace Dice_console
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                int checkNumber, numberSides, numberRolls;

                Console.WriteLine("How many sides do you want on the dice?");
                string userAnswer = Console.ReadLine();
                bool isSidesANumber = Int32.TryParse(userAnswer, out checkNumber);

                while (!isSidesANumber)
                {
                    Console.WriteLine("This was not a valid number, please enter a new number");
                    userAnswer = Console.ReadLine();
                    isSidesANumber = Int32.TryParse(userAnswer, out checkNumber);
                }
                numberSides = checkNumber;

                Console.WriteLine("How many times to do you want to roll the dice?");
                userAnswer = Console.ReadLine();
                bool isRollsANumber = Int32.TryParse(userAnswer, out checkNumber);

                while (!isRollsANumber)
                {
                    Console.WriteLine("This was not a valid number, please enter a new number");
                    userAnswer = Console.ReadLine();
                    isRollsANumber = Int32.TryParse(userAnswer, out checkNumber);
                }
                numberRolls = checkNumber;

                RollTheDice userDice = new RollTheDice(numberSides, numberRolls);
                userDice.Results = userDice.RollingDice(userDice);
                userDice.PrintOutResults(userDice);


            }
        }
    }
}
