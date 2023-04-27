using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace TwentyOne
{
    public abstract class Game
    {
        //Properties - base or abstract class make is so the class is not longer able to be instantiated
        public List<Player> Players { get; set; } 
        public string Name { get; set; } //Name of the game
        public string Dealer { get; set; }
     //Abstrack method statest that any method inheriting this class must use this method or it will not compile
        public abstract void Play();
        
        ////This method gets inherited but can be overridded
        //public virtual void ListPlayers()
        //{
        //    //Looping thru the Players property
        //    foreach (Player player in Players)
        //    {
        //        Console.WriteLine(player.Name);
        //    }
        //}
           

    }
}
