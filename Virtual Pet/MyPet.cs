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

        public void PlayLevelpt()

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

        public void HungerLevelpt()
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

        public void SleepLevelpt()
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

        public void PoopLevelpt()
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


         public void DisplayPetStatus()
        {

            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("\nPlaylevel {0}\n" +
                              "HungerLevel: {1}\n" +
                              "SleepLevel: {2}\n" +
                              "PoopLevel: {3}\n" +,
                              PlayLevel, HungerLevel, SleepLevel, PoopLevel);

            Console.WriteLine();
            Console.WriteLine("========================");




        // ChoiceMenu(my menu is in the Program.cs file, so how do I combine them?

        //I might had something for pooping but what? points for pooping or just use a method to have to pet poop.8
    }
}

// 6/25/16 I beleive I have created all of my methods. I am still confused on what operates where. Do, I set my methods in the program.cs doc or t





