using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace TwentyOne
{
    public class Deck
    {
        //Constructor
        public Deck()
        {

            Cards = new List<Card>();
            List<string> Suits = new List<string> { "Clubs", "Hearts", "Diamons", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"
            };


            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        //Properties
        public List<Card> Cards { get; set; }


        public void Shuffle(int times = 1)
        {

            //Setting the default for times makes it an optional parameter
            for (int i = 0; i < times; i++)
            {


                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                //referring to its own object
                Cards = TempList;
            }

        }
    }
}