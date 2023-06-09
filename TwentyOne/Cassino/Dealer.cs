﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace Cassino
{
    //Accessability Modifiers
    //public means it is accessible everywhere
    //If a method is private it is only accessable inside of its class
    //protected- limited to just that class or any classes that derrive from it
    //internale - only accessable to methods within the same assembly

  public  class Dealer
    {
       
        public string Name { get; set; }
        public Deck Deck{ get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //Need to make sure that memory gets disposed using is used - true on the streamwriter appends to the log
            using (StreamWriter file = new StreamWriter(@"C:\Users\amy\Desktop\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }//once this curly bracket is reached resources are disposed. This is what the using does
            Deck.Cards.RemoveAt(0);
        }
    }
}
