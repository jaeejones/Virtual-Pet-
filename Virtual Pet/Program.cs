﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        private static readonly object mymojo;

        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("\n I am Mojojo an intelgent monkey!\n");
            Console.WriteLine("\n You must be very furtunate to have me as your pet!/n");
            Console.WriteLine("Uh-Oh you are my owner?!?!");
            Console.WriteLine("\n You may become my pet! HAHAH!/n");
            VirtualPet mymojo = new VirtualPet(Console.ReadLine()); //how do I get this to read Mo JoJo Monkey's name? and why is this red?
            Console.WriteLine("\n{0} We shall see of I am lucky to have you)", mymojo.GetName());
            Console.WriteLine("\n Are you intellegent enough to care for me {0}?", mymojo.GetName());
            Console.WriteLine("\n Than get to work,now! The instructions are below!/n");
            Console.WriteLine();
            Console.WriteLine("*************************************");
        }
        static int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine(); //Add Decorations here if you have time
            Console.WriteLine("\n Here are your choices!/n");
            Console.WriteLine("\n Do you have the brains to choose intellegently/n");
            Console.WriteLine("1.Play,NOW");
            Console.WriteLine("2.Feed me!");
            Console.WriteLine("3.Put me to sleep");
            Console.WriteLine("4.Take me out to poop");
            Console.WriteLine("5.What's my badness level!"); //his tick
            Console.WriteLine("6.Leave, out of my sight!"); //Exit
            Console.WriteLine("\n Choose from the numbers above, genius!");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            return menuChoice;

            int choice = 1;

            while (choice != 5)
            {
                choice = DisplayMenu();
                if (choice == 1)
                {
                    mymojo.Play(); //
                }
                else if (choice == 2)
                {
                    mymojo.Feed();
                }
                else if (choice == 3)
                {
                    mymojo.Sleep();
                }
                else if (choice == 4)
                {
                    mymojo.Poop();
                }
                else if (choice == 5)
                {
                    mymojo.Tick();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("\n You are most honored to take care of {0}.\n", mymojo.GetName());
                    Console.WriteLine("To Exit press any key smarty!");
                }
                else
                {
                    Console.WriteLine("\nChosing a number between 1 and 5 might help!\n");
                }
            }


        }

    }
}


