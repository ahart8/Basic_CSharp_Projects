using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Cassino
{
    public class Player
    {
        //Constructor for initialziing the player with their name and amount of money
        //The constructor takes in arugements and assigns them to properties of the class
        //The constructor goes at the beginning of the file

        //Cohstructors inherit from the previous constructor. We are able to set a default
        //.this re-uses the code in the construtor below. we do not need to put code in the other constructor
        public Player(string name) : this(name, 100)
        {

        }
        
        public Player(string name, int beginningBalance)
        {
            //create an empty list card
            Hand = new List<Card>();
            //assign balance
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public Guid Id { get; set; }
        public bool Stay { get; set; }

        //Bet method should be added to the player class becaue it is the player that is doing the betting and we should keep that logic with the player entity
        public bool Bet(int amount)
        {
                if (Balance - amount<0)
            {
                Console.Write("You do not have enough to place a bet that size");
                return false; 
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }


        //Overload an operator method
        public static Game operator +(Game game, Player player)
        {
            //game.players is a list and you have to instanciate a list or it breaks when you want to add something to it
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
