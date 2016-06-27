using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class VirtualPet // These are properties? or mymojo how do I set the name
    {
        Random random = new Random(); //This fixed my calling VirtualPet in my code problem but I dont know why?
        private string v;

        public VirtualPet(string v)
        {
            this.v = v;
        }
        private string Name { get; set; }
        public int HungerLevel { get; set; }
        public int ThirstLevel { get; set; }
        public int WasteLevel { get; set; }
        public int BadnessLevel { get; set; } //the tick if he is left alone for over an hour he destroys your shoes.

 

        public void DisplayPetStatus()
        {

            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("\n\nName: {0}\n" +
                              "HungerLevel: {1}\n" +
                              "ThirstLevel: {2}\n" +
                              "WasteLevel: {3}\n" +
                              "BadnessLevel: {4}\n",
                              Name, HungerLevel, ThirstLevel, WasteLevel, BadnessLevel);

            Console.WriteLine();
            Console.WriteLine("========================");

        }

        public override HungerLevel()
        {
            if (HungerLevel = true)
            {
                Console.WriteLine("{0}: I'm hungry feed me!", Name);
            }
            else if (HungerLevel = false)
            {
                Console.WriteLine("{0}: I am full!", Name);
            }
        }


        public override ThirstLevel()
        {
            if (ThirstLevel = true)
            {
                Console.WriteLine("{0}: Get me water, now!", Name);
            }
            else if (ThirstLevel = false)
            {
                Console.WriteLine("{0}: No more water!", Name);
            }
        }
        public override WasteLevel()
        {
            if (HungerLevel = true)
            {
                Console.WriteLine("{0}: Take me out or I'll go in here!", Name);
            }
            else if (HungerLevel = false)
            {
                Console.WriteLine("{0}: Elimation complete!", Name);
            }
        }
        public override BadnessLevel() //needs a loop for when at rest, the best destroys shoes if neglected for too long. 
        {
            if (BadnessLevel = true)
            {
                Console.WriteLine("{0}: Um, feeling devious!", Name);
            }
            else if (HungerLevel = false)
            {
                Console.WriteLine("{0}: I am happy, now go!", Name);
            }
        }

        // ChoiceMenu(my menu is in the Program.cs file, so how do I combine them?

        //I might had something for pooping but what? points for pooping or just use a method to have to pet poop.8
    }
}

// 6/25/16 I beleive I have created all of my methods. I am still confused on what operates where. Do, I set my methods in the program.cs doc or the MyPet.cs doc.

