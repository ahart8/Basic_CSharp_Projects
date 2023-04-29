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

            //  int number = 5;

            //Card card1 = new Card();
            //Card card2 = card1;//give card2 the memory location of the address of card1 - accessing by reference
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);
            //
            //Console.WriteLine(card2.Face);


            Deck deck = new Deck();
            //Count x.Face where x.face=Ace
            //x represents each element in the list
            //Map this expression to each item
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //foreach(Card card in deck.Cards)
            //{
            //    if(card.Face==Face.Ace)
            //    {
            //        count++;
            //    }
            //}
            //Filter your list for features
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 535,342,23 };
            //foreach item add 5 to that item
            // int sum = numberList.Sum(x=>x+5);
            // int sum = numberList.Max();
            // int sum =numberList.Min();
            //concatenate
            int sum = numberList.Where(x => x > 20).Sum();

            Console.WriteLine(sum);

            // foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            
          // Console.WriteLine(count);

            //deck.Shuffle(3);
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();


        }
     
    }
}
