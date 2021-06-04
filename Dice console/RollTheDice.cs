using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_console
{
    class RollTheDice
    {
        public int NumberSides { get; set; }
        public int NumberRolls { get; set; }

        public int[] Results { get; set; }

        public RollTheDice (int a, int b)
        {
            NumberSides = a;
            NumberRolls = b; 
        }
        
        public int[] RollingDice(RollTheDice dice)
        {
            int[] sidesofDice = new int[dice.NumberSides];
            for (int i =0; i<dice.NumberSides; i++)
            {
                sidesofDice[i] = 0; 
            }

            Random diceResult = new Random(); 

            for (int i =0; i<dice.NumberRolls; i++)
            {
                int result = diceResult.Next(0, NumberSides);
                sidesofDice[result] += 1;
            }

            return sidesofDice; 
        }

        public void PrintOutResults (RollTheDice dice)
        {
            int[] percentages = new int[dice.NumberSides];

            for (int i = 0; i<dice.NumberSides; i++)
            {
                int percentage = (dice.Results[i]*100) / dice.NumberRolls;
                percentages[i] = percentage;
            }
            
            Console.WriteLine("Results of your rolls are: ");

            for (int i =0; i<dice.Results.Length; i++)
            {
                Console.WriteLine($"Number {i + 1} was rolled {dice.Results[i]} times which is {percentages[i]} %"); 
            }
        }
    }
}
