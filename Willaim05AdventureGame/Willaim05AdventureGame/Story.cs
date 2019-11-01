using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willaim05AdventureGame
{
   public class Story
    {
        public string[] myStoryline = new string[9];

        public void myStorylines()
        {
            myStoryline[0] = "You forget the location of the soup pot. You choose to go: 1 )basement 2)cupboard  3)garage";
            myStoryline[1] = "When you find the soup pot, you find that you lack the necessary ingredients. You choose: 1)borrow food from the neighbor  2)Drive to the supermarket to buy groceries. 3)go to the back garden to pick food.";
            myStoryline[2] = "The ingredients are ready, you choose: 1)boil water first 2)First put the ingredients in the pot ";
            myStoryline[3] = "You think the temperature of water should be: 1)100 degrees Celsius 2)80 degrees Celsius";
            myStoryline[4] = "After stewing, when you put salt, you choose: 1)1 spoon salt  2)1 tablespoon salt";
            myStoryline[5] = "Next you choose: 1)put some black condiments 2)put some red condiments";
            myStoryline[6] = "Now is the waiting time. You choose to wait: 1)25min 2)30min";

        }

    }
}
