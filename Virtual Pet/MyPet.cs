using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    public class MyPet // These are properties?
    {
        public string Name { get; set; }
        public int HungerLevel { get; set}
        public int ThirstLevel { get; set}
        public int WasteLevel { get; set}
        public int BadnessLevel { get; set} //the tick if he is left alone for over an hour he destroys your shoes.

        /*The pet class constructor
        public Pet( name,  breed, mood, hunger, badnesslevel)
        {
            Name = name;
            Breed = breed;
            Mood = mood;
            Hunger = hunger;
            IsVaccinated = isVaccinated;
        }

        public void GivePetShot()
        {
            IsVaccinated = true;
        }

        public abstract PetMood PlayWithPet();

        public abstract PetMood PunishPet();

        public abstract HungerLevel FeedPet();

        public abstract HungerLevel StarvePet();

        public void UpdatePet(HungerLevel hunger)
        {
            if (hunger != Hunger)
            {
                Hunger = hunger;
            }
        }

        public void UpdatePet(PetMood mood)
        {
            if (mood != Mood)
            {
                Mood = mood;
            }
        }*/

    
        public void DisplayPetStatus()
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
            Console.WriteLine("========================");

        }

        public override HungerLevel()
        {
            if (HungerLevel = true)
            {
                Console.WriteLine("{0}: I'm hungry feed me!", Name);
            }
            else if (HungerLevel = false)
            {
                Console.WriteLine("{0}: I am full!", Name);
            }
        }


        public override ThirstLevel()
        {
            if (ThirstLevel = true)
            {
                Console.WriteLine("{0}: Get me water, now!", Name);
            }
            else if (ThirstLevel= false)
            {
                Console.WriteLine("{0}: No more water!", Name);
            }
        }
        public override WasteLevel()
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
        }

        // ChoiceMenu(my menu is in the Program.cs file, so how do I combine them?

        //I might had something for pooping but what? points for pooping or just use a method to have to pet poop.8
    }
}

// 6/25/16 I beleive I have created all of my methods. I am still confused on what operates where. Do, I set my methods in the program.cs doc or the MyPet.cs doc.


/*  public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Name);
            sb.AppendLine("==========");
            sb.AppendFormat("Off: {0}\tDef: {1}\n", Offense, Defense);
            sb.AppendFormat("HP: {0}/{1}\n", HitPoints, MaxHitPoints);

            return sb.ToString();
        }

        /// <summary>
        /// Checks if the Dragon is alive.
        /// <para>A Dragon is alive if their <see cref="HitPoints"/> are greater than 0.</para>
        /// </summary>
        /// <returns>true if the Dragon is alive, false if they are not</returns>
        public bool IsAlive()
        {
            // TODO
            if (HitPoints < 0)
            {
                return true;
            }

            else
            {
                return false;
            }*/
