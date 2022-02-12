using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingSimulator
{
    public class Player
    {
        // constants
        const int STAKE_PER_DAY = 100;
        const int BET_PER_GAME = 1;
        const int WIN = 1;

        //Check the player status win or loss
        public static void GameStatus()
        {
            Random random = new Random();
            int stake = random.Next(1, 3);
            if (stake == WIN)
                Console.WriteLine("Playe win the game");
            else
                Console.WriteLine("Playe loss the game");
        }
    }
}
