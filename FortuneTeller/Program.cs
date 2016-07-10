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

            //combining the first and last name into a concatenated string for the first/second/third letter of birth month test
            string userFullName = string.Concat(userFirstName, userLastName).ToUpper();


            Console.WriteLine("Please enter your AGE and hit \"Enter\"");
            int userAge = int.Parse(Console.ReadLine());

            //if the user's age is even, they will retire in 17 years
            //if the user's age is odd, they will retire in 6 years

            userAge = (userAge % 2 == 0) ? 17 : 6;


            Console.WriteLine("Please enter your BIRTH MONTH and hit \"Enter\"");
            string userBirthMonth = Console.ReadLine().ToUpper();

            //Getting substrings of each of the first three letters in the birth month for the bank balance

            string firstLetterOfBirthMonth = userBirthMonth.Substring(0, 1);
            string secondLetterOfBirthMonth = userBirthMonth.Substring(1, 1);
            string thirdLetterOfBirthMonth = userBirthMonth.Substring(2, 1);

            int indexFirstLetter = userFullName.IndexOf(firstLetterOfBirthMonth);
            //Console.WriteLine(indexFirstLetter);
            int indexSecondLetter = userFullName.IndexOf(secondLetterOfBirthMonth);
            //Console.WriteLine(indexSecondLetter);
            int indexThirdLetter = userFullName.IndexOf(thirdLetterOfBirthMonth);
            //Console.WriteLine(indexThirdLetter);



            double moneyInBank = 25000.00;

            if(indexFirstLetter != -1)
            {
                moneyInBank = 8500000.12;
            }
            else if(indexSecondLetter != -1)
            {
                moneyInBank = 26500000.67;
            }
            else if(indexThirdLetter != -1)
            {
                moneyInBank = 978999.54;
            }
            else 
            {
                moneyInBank = 35000.00;
            }
            
            //Console.WriteLine(firstLetterOfBirthMonth + secondLetterOfBirthMonth + thirdLetterOfBirthMonth);

            Console.WriteLine("What is the first letter of your favorite ROYGBIV color? If you do not know what ROYGBIV is, enter \"Help\" to get a list of the ROYGBIV colors.");
            string roygbivValue = Console.ReadLine();
            roygbivValue = roygbivValue.ToUpper(); 
            
            //changing user entered cast to upper so we could run switch case
            string modeOfTransportation = "car";

            //building in the "Help" conditional

            if (roygbivValue == "HELP")
            {
                Console.WriteLine("ROYGBIV stands for \nR = Red\nO = Orange\nY = Yellow");
                Console.WriteLine("G = Green\nB = Blue\nI = Indigo\nV = Violet");
                Console.WriteLine("Please enter your favorite ROYGBIV color, and hit \"Enter\"");
                roygbivValue = Convert.ToString(Console.ReadLine());
            }
           


            //Returning a substring and applying just in case the user puts in the whole name of the color
            string firstLetterOfRoygbivValue = roygbivValue.Substring(0, 1);
            roygbivValue = firstLetterOfRoygbivValue;



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



            Console.Write(userFirstName + " " + userLastName + " will retire in " + userAge + " years ");
            Console.Write("with $" + moneyInBank + " in the bank");
            Console.Write(", a vacation home in " + userFutureLocation + " and a " + modeOfTransportation +".");



            
            
            Console.ReadLine();

        }
    }
}
