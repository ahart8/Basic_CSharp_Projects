using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.IO;
using Cassino;
using Cassino.TwentyOne;


//Name space is a way of organizing your code
//Sometimes you have 2 classes with the same name but they belong to different name spaces.  Way to handle it is to use the full path for the class



namespace TwentyOne
{
    class Program
    {
        //The main method is the entrance point of the program
        static void Main(string[] args)
        {
            //string text = "Here is some text";
            //File.WriteAllText(@"C:\Users\amy\Desktop\log.txt", text);
            // string text =File.ReadAllText(@"C:\Users\amy\Desktop\log.txt");
            //Console.Write(text);

            //Date time is a value type it is a struct meaning it is not nullable
            // DateTime yearOfBirth = new DateTime(1971, 5, 4, 8, 32, 45);
            //Time span object 
            // DateTime yearOfGraduation = new DateTime(1989, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            //Using var can come in handy when trying to save typing. If ever the datatype is obscured such as with a lambda expression we do not want to use var. 
            //Var saves from having to type out a really long data type name
            //var newDictionary = new Dictionary<string, string>;
            // var newPlayer = new Player("Amy");

            const string cassinoName = "Grand Hotel and Cassino";
            //gui global unique identifier - odds of getting a duplicated gui is so slim
            




            Console.Write("Welcome to the {0}.  Let's start by telling me your name:",cassinoName);
            //get the name of what is going to become the 21 player.
            string playerName = Console.ReadLine();
            //How much money does the player have to play with.
            Console.Write("And how much money did you bring today?");
            //Later this information will be stored in a database
            int bank = Convert.ToInt32(Console.ReadLine());
            //Ask the user if they want to play - {0} is a string formatting where a variable place holder is put into curly braces. That is where thier name will display
            Console.Write("Hello,{0}. Would you like to join a game of 21 right now?,", playerName);
            //Get the answer and check it. We use to lower so that it is easier to check for the answers. 
            string answer = Console.ReadLine().ToLower();
           
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //If they want to play create a new player object we want to initilize the player object with his name and how much he brought. To do that a constructor is created
                Player player = new Player(playerName,bank);
                //We can use a guid to trak the player. Players can have the same name but we can track the player by thier guid
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\amy\Desktop\log.txt", true))
                {
                    file.WriteLine(player.Id);
                   
                }
                    //We created a player now we should create a game
                    //Polymorphism is done - it exposes the overloaded operators in the player class
                    Game game = new TwentyOneGame();
                game += player; //Here we are adding player to the game

                //We are setting this value so it can be used in a while loop keeping the player in the game as long as he wants to play
                player.isActivelyPlaying = true;
                //They have to stay actively playing and have enough money to play
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    //Separating play from the main method helps to keep the code cleaner
                    game.Play();

                }
                //When the player is no longer playing the game we want to subtract him from the game
                game -= player;
                //Display a message after the player is over
                Console.WriteLine("Thank you for playing.");

            }
            //Goes here if they did not answer yes 
            Console.WriteLine("Feel fee tolook around the casino. Bye for now.");
        }
     
    }
}
