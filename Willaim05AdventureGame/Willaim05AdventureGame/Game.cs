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

        void example()
        {
            bool correctChosen = false;
            string input;

            while(!correctChosen)
            {
                Console.WriteLine("Where is the pot?");
                input = Console.ReadLine();

                // Option 1;
                // Option 2;
                // ...

                if (input == "1")
                {
                    correctChosen = true;
                    // Correct
                }
                else
                {
                    correctChosen = false;
                }


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
            Console.WriteLine("You plan to make a delicious stew for today's birthday party. Stay sharp, or today's party will be in big trouble! You will need to make the best choose. All choices will cause changes.");
            Console.ReadLine();

        }

        private void Gamestart()
        {
            Console.WriteLine("Welcome to the kitchen!");
            Console.ReadLine();
            Console.Clear();

            int option1;
            int option2;
            int option3;
            int option4;
            int option5;
            int option6;
            int option7;
            

            Console.WriteLine("What is your name?");
            string playerNameCreate = Console.ReadLine();

            Console.WriteLine("What is your cooking age?"); // How many years of cooking experience do you have?
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

            option1 = Convert.ToInt16(Console.ReadLine());


            if (option1 == 1)
            {
                Console.Clear();
                player.show();
                Console.WriteLine("Lucky! You find your soup pot!");
                Console.WriteLine(arrayStory.myStoryline[1]);

                option2 = Convert.ToInt16(Console.ReadLine());

                if (option2 == 1)
                {
                    Console.Clear();
                    player.show();
                    Console.WriteLine("please continue to try if the neighbor is not at home");
                    Console.WriteLine(arrayStory.myStoryline[1]);

                }

                else if (option2 == 2)
                {
                    Console.Clear();
                    player.show();
                    Console.WriteLine("You get all the ingredients!");
                    Console.WriteLine(arrayStory.myStoryline[2]);

                    option3 = Convert.ToInt16(Console.ReadLine());

                    if (option3 == 1)
                    {
                        Console.Clear();
                        player.show();
                        Console.WriteLine("Of Coure you should boil water first");
                        Console.WriteLine(arrayStory.myStoryline[3]);

                        option4 = Convert.ToInt16(Console.ReadLine());

                        if (option4 == 1)
                        {
                            Console.Clear();
                            player.show();
                            Console.WriteLine("Correct, soup's aroma +2");
                            player.AddAroma(2);
                            Console.WriteLine(arrayStory.myStoryline[4]);

                            option5 = Convert.ToInt16(Console.ReadLine());

                            if (option5 ==1)
                            {
                                Console.Clear();
                                player.show();
                                Console.WriteLine("The taste is too strong, please try again.");
                                Console.ReadLine();
                            }

                            else
                            {
                                Console.Clear();
                                player.show();
                                Console.WriteLine("The taste is good. soup's taste +2");
                                player.AddTaste(2);
                                Console.WriteLine(arrayStory.myStoryline[5]);

                                option6 = Convert.ToInt16(Console.ReadLine());

                                if (option6 ==1)
                                {
                                    Console.Clear();
                                    player.show();
                                    Console.WriteLine("Correct. Soup's appearance +2");
                                    player.AddAppearance(2);
                                    Console.WriteLine(arrayStory.myStoryline[6]);

                                    option7 = Convert.ToInt16(Console.ReadLine());

                                    if (option7 ==1)
                                    {
                                        Console.Clear();
                                        player.show();
                                        Console.WriteLine("You have successful made delicious soup! Today birthday party will be wonderful! Everone will like this decious soup!");
                                        Console.ReadLine();

                                    }

                                    else
                                    {
                                        Console.Clear();
                                        player.show();
                                        Console.WriteLine("The stewing times is too long, please try again.");
                                        Console.ReadLine();
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    player.show();
                                    Console.WriteLine("The color is wrong, please try again.");
                                    Console.ReadLine();
                                }
                            }
                        }

                        else
                        {
                            Console.Clear();
                            player.show();
                            Console.WriteLine("The temperature is not suitable, please continue to try.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        player.show();
                        Console.WriteLine("The pot is too hot and the ingredients are burnt.");
                        Console.ReadLine();

                    }

                }
                else if (option2 == 3)
                {
                    Console.Clear();
                    player.show();
                    Console.WriteLine("Well, the vegetables is not ready to harvest! You need to find your ingredients at another place.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please choose among the three options.");
                    Console.ReadLine();
                }
            }


            else if (option1 == 2)
            {
                Console.Clear();
                player.show();
                Console.WriteLine("Well , it's not here, you need keep look around!");
                Console.ReadLine();
            }

            else if (option1 == 3)
            {
                Console.Clear();
                player.show();
                Console.WriteLine("Well , it's not here, you need keep look around!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please choose among the three options.");
                Console.ReadLine();
            }

        }

        private void Credits()
        {
            Console.WriteLine("IAM tutor Pedro Tresgallo helped with the development of While loop and if/else branching. He also reviewed the scripts of story lines.");
            Console.ReadLine();
        }
            
        private void Leave()
        {
            Environment.Exit(0);

        }



    }
}
