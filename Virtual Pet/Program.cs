﻿
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

        static VirtualPet MyMojo = new VirtualPet();

        static void Main(string[] args)
        {
            // This line of code is not working after all of my work
            /*Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("\n I am Mojojo an intellgent monkey!\n");
            Console.WriteLine("\n You must be very furtunate to have me as your pet!/n");
            Console.WriteLine("Uh-Oh you are my owner?!?!");
            Console.WriteLine("\n You may become my pet! HAHAH!/n");

            Console.WriteLine("\n We shall see of I am lucky to have you");
            Console.WriteLine("\n Are you intellegent enough to care for me?");

            Console.WriteLine("\n Than get to work,now! The instructions are below!/n");
            Console.WriteLine();
            Console.WriteLine("*************************************");

               Console.WriteLine("                            /~\ ");
               Console.WriteLine("                           C oo "); //<-----pic of a Monkey,
               Console.WriteLine("                           _( ^) ");
               Console.WriteLine("                          /   ~\  \n");*/ 



            MyMojo.DisplayMenu();
            Console.ReadKey();
        }
    }

}