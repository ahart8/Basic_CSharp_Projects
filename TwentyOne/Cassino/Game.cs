using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Cassino
{
    public abstract class Game
    {
        //We want to make sure that the list is never null
        //Always make it an instanciated empty list
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();//Dictionary is also a list

        public List<Player> Players { get { return _players; } set { _players = value; } }
        //Properties - base or abstract class make is so the class is not longer able to be instantiated
         public string Name { get; set; } //Name of the game
         public Dictionary<Player, int> Bets { get { return _bets; }set { _bets = value; } }//here we return the private field is someone wants to get the bet - value means what ever they are setting it as
        //Abstract method states that any method inheriting this class must use this method or it will not compile
          public abstract void Play();
        
        ////This method gets inherited but can be overridded
        public virtual void ListPlayers()
        {
         //Looping thru the Players property
           foreach (Player player in Players)
           {
               Console.WriteLine(player.Name);
            }
        }
           

    }
}
