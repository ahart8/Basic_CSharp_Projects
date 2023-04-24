using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Game
    {
        //Properties
        public List<string> Players { get; set; } 
        public string Name { get; set; } //Name of the game
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            //Looping thru the Players property
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
           

    }
}
