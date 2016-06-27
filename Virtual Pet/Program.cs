
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        //private static readonly object mymojo;

        static void Main(string[] args)
        {


            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("\n I am Mojojo an intelgent monkey!\n");
            Console.WriteLine("\n You must be very furtunate to have me as your pet!/n");
            Console.WriteLine("Uh-Oh you are my owner?!?!");
            Console.WriteLine("\n You may become my pet! HAHAH!/n");

            Console.WriteLine("\n We shall see of I am lucky to have you");
            Console.WriteLine("\n Are you intellegent enough to care for me?");

            Console.WriteLine("\n Than get to work,now! The instructions are below!/n");
            Console.WriteLine();
            Console.WriteLine("*************************************");
        }
        public static void DisplayMenu()
        {
            VirtualPet mymojo = new VirtualPet();
            Console.WriteLine();
            Console.WriteLine("\n Here are your choices!/n");
            Console.WriteLine("\n Do you have the brains to choose intellegently/n");
            Console.WriteLine("1.Play,NOW");
            Console.WriteLine("2.Feed me!");
            Console.WriteLine("3.Put me to sleep");
            Console.WriteLine("4.Take me out to poop");
            Console.WriteLine("5.Leave, out of my sight!"); //Exit
            Console.WriteLine("\n Choose from the numbers above, genius!");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            //return menuChoice;



            while (menuChoice != 5)
            {
                if (menuChoice == 1)
                {

                    mymojo.PlayLevelpt(); //
                }
                else if (menuChoice == 2)
                {
                    mymojo.HungerLevelpt();
                }
                else if (menuChoice == 3)
                {
                    mymojo.SleepLevelpt();
                }
                else if (menuChoice == 4)
                {
                    mymojo.PoopLevelpt();
                }

                else
                {

                    Console.WriteLine("\n You are most honored to take care of me.\n");
                    Console.WriteLine("To Exit press any key smarty!");
                    Console.ReadKey();

                    break;
                }

            }


        }

    }
}
