using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        public override void Play()
        {
          throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");

            base.ListPlayers();
        }
        
    }

}
