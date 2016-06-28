using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class VirtualPet 

    { //properties
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

        public VirtualPet() //constructor
        {
            PlayLevel = 11;
            HungerLevel = 9;
            SleepLevel = 7;
            PoopLevel = 5;
           
        }

        public void DisplayMenu()
        {

            Console.Clear(); //Tip:this is a way to clear your console

            DisplayPetStatus();

            Console.WriteLine();
            Console.WriteLine("\n Here are your choices!\n");
            Console.WriteLine("\n Do you have the brains to choose intellegently\n");
            Console.WriteLine("1.Play,NOW");
            Console.WriteLine("2.Feed me!");
            Console.WriteLine("3.Put me to sleep");
            Console.WriteLine("4.I will use your toliet!");
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

                DisplayPetStatus();
                DisplayMenu();

                menuChoice = Convert.ToInt32(Console.ReadLine());
            }
           
        }
        
    public void PlayLevelpt() //method

        {

            Console.WriteLine("Mo Jojo is needs amuzement,Play with me now!");
           

            {
                Tick();
            }
       }

        private void Tick()
        {
            if (_play != 0)
            {
                PlayLevel = PlayLevel + _play;
            }
        }

        public void HungerLevelpt()
        {

            Console.WriteLine("Mo Jojo is hungry! Feed me, NOW\n");
            
                HungerLevel = HungerLevel- 9;

   
        }

        public void SleepLevelpt()
        {

            Console.WriteLine(" Mo Jojo is weary of you, I need a nap!");


            SleepLevel = SleepLevel - 7;
        }

        public void PoopLevelpt()
        {


            Console.WriteLine("Mo Jojo will use your toliet to poop!");
            
                PoopLevel = PoopLevel - 5;

        }

        /*private void Tick(int play)
        {
            if (play != 0)
            {
                PlayLevel = PlayLevel + play;
            }
        }*/

        public void DisplayPetStatus() 
        {

            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("\nPlay \t{0}", PlayLevel);
            Console.WriteLine("hunger\t{0}", HungerLevel);
            Console.WriteLine("Sleep\t{0}", SleepLevel);
            Console.WriteLine("Poop\t{0}", PoopLevel);

            Console.WriteLine();
            Console.WriteLine("========================");


      

                }
             
            }

        }






// add a tick as a method9  









