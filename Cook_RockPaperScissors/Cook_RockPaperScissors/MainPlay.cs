using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_RockPaperScissors
{
    class MainPlay
    {

        int dmg = 10;
        int dice;
        int compGuess;
        string symbol;



        Random rand = new Random();

        public int PlayerRollDice()
        {
            dice = rand.Next(1, 20);

            return dice;
        }

        public int CompRollDice()
        {
            dice = rand.Next(1, 20);

            return dice;
        }

        public string CompGuess()
        {

            compGuess = rand.Next(1, 4);
            {
                if (compGuess == 1)
                    symbol = "Rock";
                else if (compGuess == 2)
                    symbol = "Paper";
                else if (compGuess == 3)
                    symbol = "Scissors";

            }

            return symbol;
        }

        public int NoDamage()
        {
            dmg += 0;

            return dmg;
        }

        public int SubDamage()
        {
            dmg -= 2;

            return dmg;
        }

    } 
}
