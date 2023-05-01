using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace TwentyOne
{
    public class Player
    {
        //Constructor for initialziing the player with their name and amount of money
        //The constructor takes in arugements and assigns them to properties of the class
        //The constructor goes at the beginning of the file
        public Player(string name, int beginningBalance)
        {
            //create an empty list card
            Hand = new List<Card>();
            //assign balance
            Balance = beginningBalance;
            Name = name;
        }

        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        //Bet method should be added to the player class becaue it is the player that is doing the betting and we should keep that logic with the player entity
        public bool Bet(int amount)
        {
                if (Balance - amount>0)
            {
                Console.WriteLine("You do not have enough to place a bet that size");
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
