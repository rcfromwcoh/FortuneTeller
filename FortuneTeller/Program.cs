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


            //Collect user data for part 1

            Console.WriteLine("Please enter your FIRST name and hit \"Enter\"");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Please enter your LAST name and hit \"Enter\"");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Please enter your AGE and hit \"Enter\"");
            int userAge = int.Parse(Console.ReadLine());
            //if the user's age is even, they will retire in 17 years
            //if the user's age is odd, they will retire in 6 years
            userAge = (userAge % 2 == 0) ? 17 : 6;
            
            
            Console.WriteLine("Please enter your BIRTH MONTH and hit \"Enter\"");
            string userBirthMonth = Console.ReadLine();



            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, enter \"Help\" to get a list of the ROYGBIV colors.");
            string roygbivValue = Console.ReadLine();
            roygbivValue = roygbivValue.ToUpper(); //changing user entered cast to upper so we could run switch case
            if(roygbivValue == "HELP")
            {
                Console.WriteLine("ROYGBIV stands for \nR = Red\nO = Orange\nY = Yellow");
                Console.WriteLine("G = Green\nB = Blue\nI = Indigo\nV = Violet");
                Console.WriteLine("Please enter your favorite ROYGBIV color, and hit \"Enter\"");
                roygbivValue = Convert.ToString(Console.ReadLine());
            }
            string modeOfTransportation = "car";

            switch (roygbivValue)
            {
                case "R":
                    modeOfTransportation = "Range Rover";
                    break;

                case "O":
                    modeOfTransportation = "Outback SUV";
                    break;

                case "Y":
                    modeOfTransportation = "Yacht";
                    break;

                case "G":
                    modeOfTransportation = "Golf Cart";
                    break;

                case "B":
                    modeOfTransportation = "Boat";
                    break;

                case "I":
                    modeOfTransportation = "Intrepid";
                    break;

                case "V":
                    modeOfTransportation = "Viper Convertible";
                    break;

                default:
                    modeOfTransportation = "Jet Plane";
                    break;
            }
          

            Console.WriteLine("Please enter the NUMBER OF SIBLINGS you have, and hit \"Enter\"");
            int userNumberOfSiblings = int.Parse(Console.ReadLine());
            string userFutureLocation = "Cleveland";

            if(userNumberOfSiblings == 0)
            {
                userFutureLocation = "Tokyo, Japan";
            }
            else if(userNumberOfSiblings == 1)
            {
                userFutureLocation = "London, England";
            }
            else if(userNumberOfSiblings == 2)
            {
                userFutureLocation = "Sidney, Australia";
            }
            else if(userNumberOfSiblings == 3)
            {
                userFutureLocation = "Miami, Florida";
            }
            else
            {
                userFutureLocation = "Shanghai, China";
            }



            Console.Write(userFirstName + " " + userLastName + " will retire in " + userAge + " years,");
            Console.Write(" a vacation home in " + userFutureLocation + " and a " + modeOfTransportation);

            
            
            Console.ReadLine();

        }
    }
}
