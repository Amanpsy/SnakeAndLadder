using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program



    {

        public static int playingOptions(int diceRoll, int dicePosition, int option  )
        {
            switch(option)
            {
                case 0:
                    dicePosition = dicePosition - diceRoll;
                    break;

                case 1:
                    dicePosition = dicePosition + diceRoll;
                    break;

                default:
                    dicePosition = dicePosition;
                    break;
            }

            return dicePosition;

        }

            


        static void Main(string[] args)
        {

            int startPosition = 0;

            Random random = new Random();
            int diceRoll = random.Next(1,7);
            
            Console.WriteLine(" Dice position after rolling is " +diceRoll);
            Console.ReadLine();

            int option = random.Next(0,3);
            int dicePosition = startPosition;

            dicePosition = playingOptions(diceRoll,dicePosition,option);
            Console.WriteLine("Dice position after dice roll is " + dicePosition);
            
           
        }
    }
}