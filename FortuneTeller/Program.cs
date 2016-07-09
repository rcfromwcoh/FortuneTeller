using System;
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

            Console.WriteLine("Please enter your BIRTH MONTH and hit \"Enter\"");
            string userBirthMonth = Console.ReadLine();

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, enter \"Help\" to get a list of the ROYGBIV colors.");
            string roygbivValue = Console.ReadLine();

            // put the switch case here 

            Console.WriteLine("Please enter the NUMBER OF SIBLINGS you have, and hit \"Enter\"");
            int userNumberOfSiblings = int.Parse(Console.ReadLine());

            Console.WriteLine("So far, we have the following information:\n" + userFirstName + "\n" + userLastName + "\n");



            //Console.WriteLine("Your first name is " + userFirstName + ", correct? If yes, type 'yes' and 'Enter'");
            //string yesOrNo = Console.ReadLine();

            //if (yesOrNo == "yes")
            //{
            //    Console.WriteLine("Great! Hit 'enter' to continue");
            //}  

            //else
            //{

            //}

            Console.ReadLine();

        }
    }
}
