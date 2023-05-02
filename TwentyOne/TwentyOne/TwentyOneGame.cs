using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace TwentyOne
{ 
    //Twenty one game is inheriting from the game class
    public class TwentyOneGame : Game, IWalkAway
    {
        //This property is specific to the 21 game
        public TwentyOneDealer Dealer { get; set; }
        
        //The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method,propery, indexer or event
        //The Play method must be used since it is an herited method from an abstract class
        public override void Play()
        {
            //Instantiate a dealer
            Dealer = new TwentyOneDealer();
            //This game only encompusses one hand and is for multiple players
            foreach (Player player in Players)
            {
                //Reset the players hand for each round
                player.Hand = new List<Card>();
                player.Stay = false;
            }

                Dealer.Hand = new List<Card>();
                Dealer.Stay = false;
                Dealer.Deck = new Deck();
                Dealer.Deck.Shuffle();

                Console.Write
                ("Place your bet.");
               
                //Need to loop through each player so that they can place a bet.
                
                foreach (Player player in Players)
                {
                    int bet = Convert.ToInt32(Console.ReadLine());
                    bool successfullyBet = player.Bet(bet);
                    if (!successfullyBet)
                    {
                        return;//End this method
                    }
                //Use a dictionary to track player bets key=player value=bet
                //Add the players name and the bet to the dictionary
                Bets[player] = bet;
                }

            //The next step is to 2 deal the cards face up
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);


                     // Rules Check BL
                   //Check for blackjack 
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1} ", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }

                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards ard:");
                    foreach(Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if(answer=="stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if(busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You loose your bet of {1}. Your balanes is now {2}.", player.Name, Bets[player],player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if(answer=="yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;//just ends the void function
                        }

                    }
                }
            }

            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying. ");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);
                    Players.Where(x=>x.Name==entry.Key.Name).First().Balance+=entry.Value*2;
                    Dealer.Balance -= entry.Value;
                    
                }
                return;
            }

            foreach (Player player in Players)
            {
                //Make a bool take a null so you have 3 options. A nullable bool
                //player looses its false -true if they win - if a push it is null
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! Noe one wins!");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]*2);
                    player.Balance += (Bets[player]);
                }
                else
                {
                    Console.WriteLine("Dealer Wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play Again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
           

        }
        //We have this as an override method because it is an abstract method in game class
       public override void ListPlayers()
       {
            Console.WriteLine("21 Players:");

            base.ListPlayers();
       }

    }

}
