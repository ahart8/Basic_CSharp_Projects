using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //Object initialization with values
            // Card card = new Card() { Face = "King", Suit = "Spades" };
            //TwentyOneGame game =new TwentyOneGame();
            //game.Players = new List<string>() { "Amy", "Buddy", "River" };
            //game.ListPlayers();
            //Console.ReadLine();
            // game.Play();

            //List<Game> games = new List<Game>();
            //Polymorphism - one object can morph into a higher order object  - TwentyOneGame is inheriting from game
            //TwentyOneGame game = new TwentyOneGame();
            // games.Add(game);

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players =new List<string>() { "Amy", "Buddy", "River" };
            //game.ListPlayers();
            //Console.ReadLine();

            Game game = new TwentyOneGame();
            //Lists have to be instantiated in order to be able to use them
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Amy";
            game += player;
            game -=player;
            Deck deck = new Deck();
            //we are calling the method shuffle on itself. the shufffle methed is a method of the deck object. calling the method on a object of //that class
            deck.Shuffle(3);
       
           foreach( Card card in deck.Cards)
            {
            Console.WriteLine(card.Face + " of " + card.Suit);
            }
          Console.WriteLine(deck.Cards.Count);
          Console.ReadLine();
        }

       
        
        //Overload method use when there are a lot of parameters or when using an api
        //public static Deck Shuffle(Deck deck, int times)
        //{ 
        //    for(int i = 0; i < times; i++)
        //    {
        //        deck=Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
