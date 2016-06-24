using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Program
    {
        /*
         * Message from Pet
         *Directions for owner

         */

        static void Main(string[] args)
        {
            while (true)

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hello, oh you are my owner!");
            Console.WriteLine("Will you love me and take care fo me?");
            Console.WriteLine("Im so lucky to have you!");
            Console.WriteLine("Directions for owner,e.i ,if you want to feed me press 1, and so forth");
            Console.WriteLine("1.Let'play");//Or I'll make a mess

            Console.WriteLine("2.I'm hungry in my tummy");
            Console.WriteLine("3.Im so sleepy");
            Console.WriteLine("4.I need to potty,speedy!");

            Console.WriteLine("5. Uh-oh, I don't feel so good!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //print out the menu
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)


            {
                Playpts(); //initiate the method to play with the pet and earn points 


            }
            else if (choice == 2)
            {
                Feedpts(); //initiate the method to feed the pet and earn points 

            }
            else if (choice == 3)
            {
                Sleeppts();//initiate the method to rest the pet and earn points 
            }
            else if (choice == 4)
            {
                Pottypts(); //initiate the method to rest the pet and earn points 

            }
            else if (choice == 5)
            {

            }
            else
            {
                //Unknown choice!
                Console.WriteLine("Pick 1-5 to help me stay alive");
            }
        }
    }
}

