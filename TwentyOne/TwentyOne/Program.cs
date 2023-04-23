﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            
            //We are calling the method shuffle on itself. The shufffle methed is a method of the deck object. Calling the method on a object of that class
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
