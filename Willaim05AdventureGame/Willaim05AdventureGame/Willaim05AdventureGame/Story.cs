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
            myStoryline[0] = "You forget the location of the soup pot. You choose to go:";
            myStoryline[1] = "When you find the soup pot, you find that you lack the necessary ingredients. You choose:";
            myStoryline[2] = "";
            myStoryline[3] = "You think the temperature of water should be:";
            myStoryline[4] = "After stewing, when you put salt, you choose:";
            myStoryline[5] = "Next you choose:";
            myStoryline[6] = "Of course, delicious soup needs meat to continue stewing. You choose:";
            myStoryline[7] = "You are ready for the secret seasoning, but you need to choose the seasoning which is more delicious. You choose:";
            myStoryline[8] = "Now is the last waiting time. You choose to wait:";

        }

    }
}
