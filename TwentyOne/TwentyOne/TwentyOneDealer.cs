using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    //A 21 dealer is a dealer so it inherits from the dealer class
    //It has some specific properties that do not apply to all dealers. 
   public class TwentyOneDealer : Dealer
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
