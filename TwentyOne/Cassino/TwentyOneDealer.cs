using System;
using System.Collections.Generic;
using System.Text;

namespace Cassino.TwentyOne
{
    //A 21 dealer is a dealer so it inherits from the dealer class
    //It has some specific properties that do not apply to all dealers. 
   public class TwentyOneDealer : Dealer
    {
        //This is how it should be done anytime you are dealing with collections
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
