using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class VirtualPet 

    {
        private int _play;
        public int PlayLevel
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

        public VirtualPet()
        {
            PlayLevel = 11;
            HungerLevel = 9;
            SleepLevel = 7;
            PoopLevel = 5;
           
        }

        public void DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine("\n Here are your choices!\n");
            Console.WriteLine("\n Do you have the brains to choose intellegently\n");
            Console.WriteLine("1.Play,NOW");
            Console.WriteLine("2.Feed me!");
            Console.WriteLine("3.Put me to sleep");
            Console.WriteLine("4.Take me out to poop");
            Console.WriteLine("5.Leave, out of my sight!"); //Exit


            Console.WriteLine("\n Choose from the numbers above, genius!");

            int menuChoice = Convert.ToInt32(Console.ReadLine());


            while (menuChoice != 5)
            {
                if (menuChoice == 1)
                {

                    PlayLevelpt();
                }
                else if (menuChoice == 2)
                {
                    HungerLevelpt();
                }
                else if (menuChoice == 3)
                {
                    SleepLevelpt();
                }
                else if (menuChoice == 4)
                {
                    PoopLevelpt();
                }

                else
                {

                    Console.WriteLine("\n You are most honored to take care of me.\n");
                    Console.WriteLine("To Exit press any key smarty!");



                }



            }
            Console.ReadKey();
        }
        
    public void PlayLevelpt()

        {

            Console.WriteLine("Mo Jojo is needs amuzement,Play with me now!");
            //int fun = int.Parse(Console.ReadLine());

            //if (fun == 2)
            
               PlayLevel = PlayLevel- 11;

            DisplayPetStatus();
        }

        public void HungerLevelpt()
        {

            Console.WriteLine("Mo Jojo is hungry! Feed me, NOW\n");
            //int bananas = int.Parse(Console.ReadLine());
            //if (bananas == 2)
            
                HungerLevel = HungerLevel- 9;

            DisplayPetStatus();
        }

        public void SleepLevelpt()
        {

            Console.WriteLine(" Mo Jojo is weary of you, I need a nap!");
            //int rest = int.Parse(Console.ReadLine());

            //if (rest == 1)
                

            DisplayPetStatus();
        }

        public void PoopLevelpt()
        {


            Console.WriteLine("Mo Jojo will use your toliet to poop!");
           // int _poop = int.Parse(Console.ReadLine());
            //if (_poop == 1)
            
                PoopLevel = PoopLevel - 5;
            


            DisplayPetStatus();

        }


        public void DisplayPetStatus() //See resource.
        {

            Console.WriteLine("=======================");
            Console.WriteLine();
            /*Console.WriteLine("\nPlay {0} \n" + "Food: {1}\n" + "Sleep: {2}\n" +
                              "Poop: {3}\n" + PlayLevel, SleepLevel, HungerLevel, PoopLevel);*/

            Console.WriteLine();
            Console.WriteLine("========================");


            if  (PlayLevel >= 11 && PlayLevel < 11)
                {
                    Console.WriteLine("Play with me!");
                }
                if (PlayLevel >= 10)
                {
                    Console.WriteLine("You will punshied for your lack of fun!");

                }
                if (HungerLevel >= 9 && HungerLevel < 9)
                {
                    Console.WriteLine("Feed Me!");
                }
                if (HungerLevel >= 100)
                {
                    Console.WriteLine("I will now distroy your kitchen for food!/n");

                }
                if (SleepLevel >= 7 && SleepLevel< 7)
                {
                    Console.WriteLine("I am sleepy!\n");
                }
                if (SleepLevel >= 100)
                {
                    Console.WriteLine("YOUR PET HAS LEFT YOU FOR SOMEONE MORE FUN!");

                }

                if (PlayLevel < 0)
                {
                    PlayLevel = 0;
                }

                if (HungerLevel< 0)
                {
                    HungerLevel = 0;
                }

                if (SleepLevel < 0)
                {
                    SleepLevel= 0;
                }
                if (PoopLevel < 0)
                {
                    PoopLevel = 0;

                }
                Console.ReadKey();
            }

        }

    } 








// 6/25/16 I beleive I have created all of my methods. I am still confused on what operates where. Do, I set my methods in the program.cs doc or t


// ChoiceMenu(my menu is in the Program.cs file, so how do I combine them?

//I might had something for pooping but what? points for pooping or just use a method to have to pet poop.8


