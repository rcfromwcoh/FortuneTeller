﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fortune Teller Program

            Console.WriteLine("Welcome to the Fortune Teller Program! Hit \"Enter\" to continue...");
            Console.ReadKey();


            //Part 1

            Console.WriteLine("Please enter your FIRST name and hit \"Enter\"");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Please enter your LAST name and hit \"Enter\"");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Please enter your AGE and hit \"Enter\"");
            int userAge = int.Parse(Console.ReadLine());
            //int retirementYears = 1;
            if (userAge % 2 == 0)
            {
                //if the user's age is even, they will retire in 47 years
                int yearsUntilRetirement = 47;
                Console.WriteLine(yearsUntilRetirement);

            }
            else 
            {
                //if the user's age is odd, they will retire in 6 years
                int retirementYearsChanged = 6;
                Console.WriteLine(retirementYearsChanged);
            }
            
            Console.WriteLine("Please enter your BIRTH MONTH and hit \"Enter\"");
            string userBirthMonth = Console.ReadLine();

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, enter \"Help\" to get a list of the ROYGBIV colors.");
            string roygbivValue = Console.ReadLine();

            if (roygbivValue == "R" || roygbivValue == "r")
            {
                Console.WriteLine("Red");
            }

            // put the switch case here 

            Console.WriteLine("Please enter the NUMBER OF SIBLINGS you have, and hit \"Enter\"");
            int userNumberOfSiblings = int.Parse(Console.ReadLine());

           

            Console.Write(userFirstName + " " + userLastName + " will retire in ");

            
            
            Console.ReadLine();

        }
    }
}
