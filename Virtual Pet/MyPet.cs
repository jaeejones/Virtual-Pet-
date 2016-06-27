

       /* public  hungerLevel()
        {
            if (hungerLevel = true)
            {
                Console.WriteLine("{0}: I'm hungry feed me!", Name);
            }
            else if (hungerLevel = false)
            {
                Console.WriteLine("{0}: I am full!", Name);
            }
     
        public override wasteLevel()
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
        }*/

        // ChoiceMenu(my menu is in the Program.cs file, so how do I combine them?

        //I might had something for pooping but what? points for pooping or just use a method to have to pet poop.8
    }
}

// 6/25/16 I beleive I have created all of my methods. I am still confused on what operates where. Do, I set my methods in the program.cs doc or the MyPet.cs doc.

//public VirtualPet()
{
    //Todo
    /* hungerLevel = 9;
     playLevel = 7;
     sleepLevel = 5;
     wastLeavel = 3;*/

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class VirtualPet // These are properties? or mymojo how do I set the name
    {
        private int _play;
        public int Playlevel
        {
            get
            {
                return _play;
            }
            set
            {
                _play = value;
            }

        }

        private int _hunger;
        public int HungerLevel
        {
            get
            {
                return _hunger;
            }
            set
            {
                _hunger = value;
            }
        }

        private int _sleep;
        public int SleepLevel
        {
            get
            {
                return _sleep;
            }
            set
            {
                _sleep = value;
            }
        }

        private int _poop;
        public int PoopLevel
        {
            get
            {
                return _poop;
            }
            set
            {
                _poop = value;
            }
        }

        public void PlayLevel()

        {

            Console.WriteLine("Mo Jojo is needs amuzement,Play with me now!");
            int fun = int.Parse(Console.ReadLine());

            if (fun == 2)
            {
                _play = _play - 11;
                Console.WriteLine("I have been appropriately entertained, now GO!");

            }

            DisplayPetStatus();
        }

        public void HungerLevel()
        {

            Console.WriteLine("Mo Jojo is hungry! Feed me, NOW\n");
            int bananas = int.Parse(Console.ReadLine());
            if (bananas == 2)
            {
                _hunger = _hunger - 9;

                Console.WriteLine("You have Satified Me!\n");

            }

            DisplayPetStatus();
        }

        public void SleepLevel()
        {

            Console.WriteLine(" Mo Jojo is weary of you, I need a nap!");
            int rest = int.Parse(Console.ReadLine());
            if (rest == 1)
            {
                _sleep = _sleep - 7;
                Console.WriteLine("ZZZZZZZZZ!");

            }

            DisplayPetStatus();
        }

        public void PoopLevel()
        {


            Console.WriteLine("Mo Jojo will use your toliet to poop!");
            int _poop = int.Parse(Console.ReadLine());
            if (_poop == 1)
            {
                _poop = _poop - 5;

                Console.WriteLine("Now you must clean your toliet, heheh!");
            }


            DisplayPetStatus();

        }


        /*public void DisplayPetStatus()
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
            Console.WriteLine("========================");*/




        // ChoiceMenu(my menu is in the Program.cs file, so how do I combine them?

        //I might had something for pooping but what? points for pooping or just use a method to have to pet poop.8
    }
}

// 6/25/16 I beleive I have created all of my methods. I am still confused on what operates where. Do, I set my methods in the program.cs doc or t





