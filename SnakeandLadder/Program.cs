using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program

    {

        static int playingOptions(int diceRoll, int dicePosition, int option)
        {
            switch (option)
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
            int endPosition = 100;


            Random random = new Random();

            string[] chooseOption = { "Snake", "Ladder", "Noplay" };

            int positionReached = startPosition;

            while (positionReached != endPosition)
            {
                if (positionReached < startPosition)
                {
                    positionReached = startPosition;
                }

                int diceRoll = random.Next(1, 7);

                Console.WriteLine(" Dice position after rolling is " + diceRoll);
                

                int option = random.Next(0, 3);

                Console.WriteLine("your dice value is " + chooseOption[option]);

                positionReached = playingOptions(diceRoll, positionReached, option);


                if (positionReached > endPosition)
                {
                    positionReached = positionReached - diceRoll;

                }
                Console.WriteLine("Your dice position after dice roll is : " + positionReached);

            }

                Console.WriteLine("you have reached to :" + positionReached + "\n woooaahh You Won, Game is ended");


                Console.ReadLine();


            }
        }
    }
