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


        public void DisplayPetStatus() //See resource.
        {

            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("\nPlay {0} \n" + "Food: {1}\n" + "Sleep: {2}\n" +
                              "Poop: {3}\n" + _play, _hunger, _sleep, _poop);

            Console.WriteLine();
            Console.WriteLine("========================");

            {
                if (_play >= 11 && _play < 11)
                {
                    Console.WriteLine("Play with me!");
                }
                if (_play >= 10)
                {
                    Console.WriteLine("You will punshied for your lack of fun!");

                }
                if (_hunger >= 9 && _hunger < 9)
                {
                    Console.WriteLine("Feed Me!");
                }
                if (_hunger >= 100)
                {
                    Console.WriteLine("I will now distroy your kitchen for food!/n");

                }
                if (_sleep >= 7 && _sleep < 7)
                {
                    Console.WriteLine("I am sleepy!\n");
                }
                if (_sleep >= 100)
                {
                    Console.WriteLine("YOUR PET HAS LEFT YOU FOR SOMEONE MORE FUN!");

                }

                if (_play < 0)
                {
                    _play = 0;
                }

                if (_hunger < 0)
                {
                    _hunger = 0;
                }

                if (_sleep < 0)
                {
                    _sleep = 0;
                }
                if (_poop < 0)
                {
                    _poop = 0;
          
                }
                Console.ReadKey();
            }
            
        }

        
    }
}

// 6/25/16 I beleive I have created all of my methods. I am still confused on what operates where. Do, I set my methods in the program.cs doc or t


// ChoiceMenu(my menu is in the Program.cs file, so how do I combine them?

//I might had something for pooping but what? points for pooping or just use a method to have to pet poop.8


