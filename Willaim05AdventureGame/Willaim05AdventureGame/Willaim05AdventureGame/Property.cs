using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willaim05AdventureGame
{
    public class Property
    {
        public string playerName;
        public int cookingAge;
        public int taste;
        public int appearance;
        public int aroma;

        public Property()
        {

        }

        public Property(string playerNameInput, int cookingAgeInput)
        {
            playerName = playerNameInput;
            cookingAge = cookingAgeInput;
            taste = 0;
            appearance = 0;
            aroma = 0; 
        }

        public void playerInfo()
        {
            Console.WriteLine("Your name is:" + this.playerName);
            Console.WriteLine("Your cooking age is:" + this.playerName);
            Console.WriteLine("Your soup taste is:" + this.taste);
            Console.WriteLine("Your soup appearance is:" + this.appearance);
            Console.WriteLine("Your soup aroma is:" + this.aroma);

        }

        public void show()
        {
            Console.WriteLine("Name: {0}", this.playerName);
            Console.WriteLine("Taste: {0}\n", this.taste);
            Console.WriteLine("Appearance: {0}\n",this.appearance);
            Console.WriteLine("Aroma: {0}\n",this.aroma);
        }

        public int AddTaste(int tasteValue)
        {
            taste += tasteValue;
            return this.taste;
        }

        public int AddAppearance(int appearanceValue)
        {
            appearance += appearanceValue;
            return this.appearance;
        }

        public int AddAroma(int aromaValue)
        {
            aroma += aromaValue;
            return this.aroma;
        }


    }
}

