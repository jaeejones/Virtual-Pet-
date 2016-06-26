using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menu Choices, Choose Wisely!");
            Console.WriteLine("1.Play,NOW");
            Console.WriteLine("2. Feed me!");
            Console.WriteLine("3. Put me to sleep");
            Console.WriteLine("4. Take me out to poop");
            Console.WriteLine("5.What's my badness level!"); //his tick
            Console.WriteLine("6. Exit");
            Console.WriteLine("\n Choose from the numbers above, genius!");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            return menuChoice;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Uh-Oh you are my owner?!?!");
            Console.WriteLine("\n I am Mo JoJo Monkey! Who are you?");
            VirtualPet mymojo = new VirtualPet(Console.ReadLine()); //how do I get this to read Mo JoJo Monkey's name?
            Console.WriteLine("\n{0} We shall see of I am lucky to have to have you:)", mymojo.GetName());
            Console.WriteLine("\n Are you intellegent enough to care for me {0}?", mymojo.GetName());

            int choice = 1;
            while (choice != 5)
            {
                choice = Menu();
                if (choice == 1)
                {
                    mymojo.Play();
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
                    Console.WriteLine("\n You are most honored to take care of {0}.\n", myPet.GetName());
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

 