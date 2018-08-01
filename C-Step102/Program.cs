using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step102
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1:
            string[] UserInputs = new string[3];
            Console.WriteLine("Type three words. Hit enter after wach word.");
            for (int i = 0; i < 3; i++)
            {
                UserInputs[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(UserInputs[i]);
            }
            Console.ReadLine();

            //Part 2: (infinite loop before being changed into a comment)
            //for (; ; )
            //Part 3 & 4:
            for (int i=1; i<3; i++)
            {
                Console.WriteLine("Infinite loop!");
            }

            //Part 5:
            for (int j=1; j<= 5; j++)
            {
                Console.WriteLine(j);
            }

            //Part 6:
            List<string> FavDays = new List<string>();
            FavDays.Add("Friday");
            FavDays.Add("Saturday");
            FavDays.Add("Thursday");
            while(true)
            {
                Console.WriteLine("What is one of my favorite days of the week?");
                string Guess = Console.ReadLine();
                if (FavDays.Contains(Guess))
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine(FavDays.IndexOf(Guess));
                    //Part 8:
                    break;
                }
                else
                {
                    //Part 7:
                    Console.WriteLine(Guess + " is not on the list. Try again!");
                }
            }

            //Part 9:
            List<string> FavPet = new List<string> ();
            FavPet.Add("Dog");
            FavPet.Add("Cat");
            FavPet.Add("Dog");
            FavPet.Add("Bird");
            FavPet.Add("Dog");
            FavPet.Add("Cat");
            FavPet.Add("Snake");
            FavPet.Add("Hamster");
            FavPet.Add("Rabbit");
            FavPet.Add("Rabbit");

            Console.WriteLine("What is your favorite pet?");
            string Pet = Console.ReadLine();

            if (FavPet.Contains(Pet))
            {
                for (int i = 0; i < FavPet.Count; i++)
                {

                    if (FavPet[i] == Pet)
                    {
                        Console.WriteLine(FavPet.IndexOf(Pet));
                    }

                }
            }
            else
            {
                //Part 10
                Console.WriteLine("That animal is not on the list.");
            }

            //Part 11
            List<string> Homes = new List<string>();
            Homes.Add("House");
            Homes.Add("House");
            Homes.Add("Apartment");
            Homes.Add("Apartment");
            Homes.Add("Apartment");
            Console.WriteLine("Do you live in a house or apartment?");
            string YourHome = Console.ReadLine();
            int count = 0;
            foreach (string home in Homes)
            {
                if (home == YourHome)
                {
                    count = count + 1;
                }
                
            }
            if (Homes.Contains(YourHome))
            {
                Console.WriteLine(YourHome + " is your home.");
                Console.WriteLine("It is on the list " + count + " times!");
            }

            Console.ReadLine();
        }
    }
}
