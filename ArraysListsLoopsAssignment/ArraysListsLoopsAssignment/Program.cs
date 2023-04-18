using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        static void Main()
        {
        Console.WriteLine("Console App Part 1\nPress any key to continue\n\n");
        Console.ReadKey();
        string[] songArray = new string[5];
        int i;
        do
        {
            //To create an infinite loop remove everything in the brackets of the for loop
            for (i = 0; i < 5; i++)
            {
                Console.Write("Enter the names of 5 your favorite songs:");
                songArray[i] = Console.ReadLine();
            }

        } while (i < 5);

        foreach (string song in songArray)
        {
            Console.WriteLine(song);
        }

        //Create and fix an infinite loop to create the loop never set isValid to true. To fix it I set isValid=true right after the Console.WriteLine
        Console.WriteLine("Console App Part 3\nPress any key to continue\n\n");
        Console.ReadKey();
        bool isValid = false;
        while (!isValid)
        {
            Console.WriteLine("Amy is so cool!");
            isValid = true;
        }

        //Loop where the comparison that is use to continue iterating the loop is <
      
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("Amy is very cool!");
            j++;
        }

        //Loop where the comparison that is used to continue interating the loop is <=
        int k = 0;
        while (k <= 5)
        {
            Console.WriteLine("Amy is super cool!");
            k++;
        }


        //This section of code returns the index of the list element if there is a match
        Console.WriteLine("Console App Part 4\nPress any key to continue\n\n");
        Console.ReadKey();
        List<string> colorList = new List<string> { "red", "blue", "yellow", "green" };
        Console.Write("Guess a color: ");
        string guessedColor = Console.ReadLine();
        string color = guessedColor.ToLower();// Change the entered value to lower case to match the casing in the list
        int index = colorList.FindIndex(a => a.Contains(guessedColor));

        bool isGuessed = false;
        do
        {
            switch (color)
            {
                case "red":

                    Console.WriteLine("You guessed red. The index of the color is: " + index);
                    isGuessed = true;
                    break;

                case "blue":

                    Console.WriteLine("You guessed blue. The index of the color is: " + index);
                    isGuessed = true;
                    break;

                case "yellow":

                    Console.WriteLine("You guessed yellow. The index of the color is: " + index);
                    isGuessed = true;
                    break;

                case "green":

                    Console.WriteLine("You guessed green The index of the color is: " + index);
                    isGuessed = true;
                    break;

                default:
                    Console.WriteLine("You guessed wrong");
                    Console.Write("Guess another color: ");
                    guessedColor = Console.ReadLine();
                    color = guessedColor.ToLower();
                    break;
            }
        } while (!isGuessed);


        //This section of code has a list of strings that has 2 identical strings
        // The user inputs a guess.If it is incorrect tell the user they guess wrong
        //if the guess is correct loop and display the indexs of the matches
        Console.WriteLine("Console App Part 5\nPress any key to continue\n\n");
        Console.ReadKey();

        List<string> flowerList = new List<string> { "daisy", "rose", "violet", "gardenia", "violet", "tulip" };

        Console.Write("Guess the names of my favorite flowers: ");
        string guessedFlower = Console.ReadLine();
        string flower = guessedFlower.ToLower(); // Change the entered value to lower case to match the casing in the list
        int index1 = flowerList.FindIndex(b => b.Contains(flower));

        switch (flower)
        {

            case "daisy":
                Console.WriteLine("You guessed: " + flower + " The index is" + index1);
                break;
            case "rose":
                Console.WriteLine("You guessed: " + flower + " The index is" + index1);
                break;
            case "violet":
                Console.WriteLine("You guessed: " + flower + " The first index for this list element is: " + index1);
                Console.WriteLine("The last index for this list element is: " + flowerList.LastIndexOf(flower));
                break;
            case "gardenia":
                Console.WriteLine("You guessed: " + flower + " The index is" + index1);
                break;
            case "tulip":
                Console.WriteLine("You guessed: " + flower + " The index is" + index1);
                break;

            default:
                Console.WriteLine("You guessed wrong");
                Console.Read();
                break;
        }

        //Create a list of strings that has at least 2 itentical strings in the lits
        //Loop throught the list and display the strings in the list and indicate if it is unique or duplicated
        Console.WriteLine("Console App Part 6\nPress any key to continue\n\n");
        Console.ReadKey();
        List<string> animals = new List<string> { "cat", "dog", "turtle", "fish","dog","snake","turtle" };
   
            //Group the strings together that have a count greater than 1
            IEnumerable<string> duplicates = from x in animals
                                             group x by x into g
                                             where g.Count() > 1
                                             select g.Key;
           string dupList= string.Join(",", duplicates);
      
            string[] types = dupList.Split(',');
            foreach (string type in types)
            {
                Console.WriteLine(type+" - this item is duplicated");
            }
            //Group the strings that have a count of 1 meaning that they are not duplicated
            IEnumerable<string> nonDuplicates = from xx in animals
                                                group xx by xx into gg
                                                where gg.Count() == 1
                                                select gg.Key;
           
            string nonDupList=String.Join(",",nonDuplicates);
            string[] types1 = nonDupList.Split(',');
            foreach (string type1 in types1)
            {
                Console.WriteLine(type1+" - this item is unigue");
            }

        Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                System.Environment.Exit(0);
    }
    }

