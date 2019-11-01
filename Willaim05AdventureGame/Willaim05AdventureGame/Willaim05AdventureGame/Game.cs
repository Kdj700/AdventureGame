using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willaim05AdventureGame
{
    public class Game
    {
        public void Run()
        {
            bool appRunning = true;
            Header();

            while (appRunning) 
            {
                Menu();
            }
        }

        public void Menu()
        {
            Console.WriteLine("Are you ready? What would you like to do now?");
            Console.WriteLine("1)Read Instructions 2)Start Game 3)Show Credits 4)Leave\n");
            int menuSelection = Int32.Parse(Console.ReadLine());
            switch (menuSelection)
            {
              
                case 1:
                    Instructions();
                    break;

            
                case 2:
                    Gamestart();
                    break;

                case 3:
                    Credits();
                    break;

                case 4:
                    Leave();
                    break;


                default:
                    Console.WriteLine("You did not choose one of the options provided.\n");
                    Console.WriteLine("Please choose an option from the list below");
                    Console.WriteLine("1)Read Instructions 2)Play Game 3)See Credits 4)Exit\n");
                    break;

            }
        }

        private void Header()
        {
            Console.WriteLine("=========================================\n");
            Console.WriteLine("Welcome to My Adventure Game!\n");
            Console.WriteLine("=========================================\n");
        }

        private void Instructions()
        {
            Console.WriteLine("ffffffff");
            Console.ReadLine();

        }

        private void Gamestart()
        {
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your name?");
            string playerNameCreate = Console.ReadLine();

            Console.WriteLine("What is your cooking age?");
            int playerCookingAgeCreate = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            Property player = new Property(playerNameCreate, playerCookingAgeCreate);
            player.playerInfo();
            Console.ReadKey();
            Console.Clear();

            Story arrayStory = new Story();
            arrayStory.myStorylines();

            player.show();

            Console.WriteLine(arrayStory.myStoryline[0]);
            Console.WriteLine(arrayStory.myStoryline[1]);

            if (arrayStory 1 == 1)
            {
                Console.Clear();
                myChar1.HUD();
                Console.WriteLine([2]);
                Console.ReadLine();
            }

            else if (choice1 == 2)












        }

        private void Credits()
        {
            Console.WriteLine("fffffff");
            Console.ReadLine();
        }
            
        private void Leave()
        {
            Environment.Exit(0);

        }



    }
}
