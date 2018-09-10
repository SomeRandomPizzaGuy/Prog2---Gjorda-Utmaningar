using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By Edvin

namespace Apartment_Prog_2
{
    class Program
    {
        // Variabler som kan nås överalt
        static int roomAmaunt = 20;
        static int apartmentOneRoomCount = 0;
        static int apartmentTwoRoomCount = 0;
        static int apartmentThreeRoomCount = 0;
        static int apartmentFourRoomCount = 0;
        static int apartmentFiveRoomCount = 0;
        static int apartmentSixRoomCount = 0;
        static int apartmentSevenRoomCount = 0;

        static void Main(string[] args)
        {
            int userMainMenuChoise = -1;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("Apartment editor");
                Console.WriteLine("Choose 1 to start to edit");
                Console.WriteLine("Choose 2 to view the apartmets");
                Console.WriteLine("Choose 0 to close the program");
                Console.Write("Write your choise here: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        MainApartmentMenu();
                    }
                    else if (userMainMenuChoise == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Aparment 1 have " + apartmentOneRoomCount + " rooms");
                        Console.WriteLine("Aparment 2 have " + apartmentTwoRoomCount + " rooms");
                        Console.WriteLine("Aparment 3 have " + apartmentThreeRoomCount + " rooms");
                        Console.WriteLine("Aparment 4 have " + apartmentFourRoomCount + " rooms");
                        Console.WriteLine("Aparment 5 have " + apartmentFiveRoomCount + " rooms");
                        Console.WriteLine("Aparment 6 have " + apartmentSixRoomCount + " rooms");
                        Console.WriteLine("Aparment 7 have " + apartmentSevenRoomCount + " rooms");
                        Console.WriteLine("How many rooms you have left: " + roomAmaunt);
                        Console.ReadLine();
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);
        }

        static void MainApartmentMenu(int roomAmount = 20)
        {
            int userMainMenuChoise = -1;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose an apartment between 1-7 to edit");
                Console.WriteLine("Select 0 to move back");
                Console.WriteLine("Rooms left: " + roomAmount);
                Console.Write("Your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        ApartmentOne();
                    }
                    else if (userMainMenuChoise == 2)
                    {
                        ApartmentTwo();
                    }
                    else if (userMainMenuChoise == 3)
                    {
                        ApartmentThree();
                    }
                    else if (userMainMenuChoise == 4)
                    {
                        ApartmentFour();
                    }
                    else if (userMainMenuChoise == 5)
                    {
                        ApartmentFive();
                    }
                    else if (userMainMenuChoise == 6)
                    {
                        ApartmentSix();
                    }
                    else if (userMainMenuChoise == 7)
                    {
                        ApartmentSeven();
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Could not find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Numbers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);
        }

        static int ApartmentOne()
        {
            
            int userMainMenuChoise = -2;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("This is Appartment 1");
                Console.WriteLine("Choose 1 to ad a room");
                Console.WriteLine("Choose -1 to subtract a room");
                Console.WriteLine("Choose 0 to move back");
                Console.WriteLine("This apartment currently has " + apartmentOneRoomCount + " rooms");
                Console.WriteLine("You have " + roomAmaunt + " rooms left");
                Console.Write("Write your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        if (roomAmaunt > 0)
                        {
                            apartmentOneRoomCount++;

                            roomAmaunt--;
                        }
                        else
                        {
                            Console.WriteLine("Not enough spare rooms, subtract some rooms from other " +
                                "apartments to add here");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == -1)
                    {
                        if (apartmentOneRoomCount > 0)
                        {
                            apartmentOneRoomCount--;

                            roomAmaunt++;
                        }
                        else
                        {
                            Console.WriteLine("Not enough rooms, an apartment can't have negitive rooms");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            return apartmentOneRoomCount;
        }

        static int ApartmentTwo()
        {

            int userMainMenuChoise = -2;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("This is Appartment 2");
                Console.WriteLine("Choose 1 to ad a room");
                Console.WriteLine("Choose -1 to subtract a room");
                Console.WriteLine("Choose 0 to move back");
                Console.WriteLine("This apartment currently has " + apartmentTwoRoomCount + " rooms");
                Console.WriteLine("You have " + roomAmaunt + " rooms left");
                Console.Write("Write your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        if (roomAmaunt > 0)
                        {
                            apartmentTwoRoomCount++;

                            roomAmaunt--;
                        }
                        else
                        {
                            Console.WriteLine("Not enough spare rooms, subtract some rooms from other " +
                                "apartments to add here");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == -1)
                    {
                        if (apartmentTwoRoomCount > 0)
                        {
                            apartmentTwoRoomCount--;

                            roomAmaunt++;
                        }
                        else
                        {
                            Console.WriteLine("Not enough rooms, an apartment can't have negitive rooms");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            return apartmentTwoRoomCount;
        }

        static int ApartmentThree()
        {

            int userMainMenuChoise = -2;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("This is Appartment 3");
                Console.WriteLine("Choose 1 to ad a room");
                Console.WriteLine("Choose -1 to subtract a room");
                Console.WriteLine("Choose 0 to move back");
                Console.WriteLine("This apartment currently has " + apartmentThreeRoomCount + " rooms");
                Console.WriteLine("You have " + roomAmaunt + " rooms left");
                Console.Write("Write your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        if (roomAmaunt > 0)
                        {
                            apartmentThreeRoomCount++;

                            roomAmaunt--;
                        }
                        else
                        {
                            Console.WriteLine("Not enough spare rooms, subtract some rooms from other " +
                                "apartments to add here");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == -1)
                    {
                        if (apartmentThreeRoomCount > 0)
                        {
                            apartmentThreeRoomCount--;

                            roomAmaunt++;
                        }
                        else
                        {
                            Console.WriteLine("Not enough rooms, an apartment can't have negitive rooms");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            return apartmentThreeRoomCount;
        }

        static int ApartmentFour()
        {

            int userMainMenuChoise = -2;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("This is Appartment 4");
                Console.WriteLine("Choose 1 to ad a room");
                Console.WriteLine("Choose -1 to subtract a room");
                Console.WriteLine("Choose 0 to move back");
                Console.WriteLine("This apartment currently has " + apartmentFourRoomCount + " rooms");
                Console.WriteLine("You have " + roomAmaunt + " rooms left");
                Console.Write("Write your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        if (roomAmaunt > 0)
                        {
                            apartmentFourRoomCount++;

                            roomAmaunt--;
                        }
                        else
                        {
                            Console.WriteLine("Not enough spare rooms, subtract some rooms from other " +
                                "apartments to add here");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == -1)
                    {
                        if (apartmentFourRoomCount > 0)
                        {
                            apartmentFourRoomCount--;

                            roomAmaunt++;
                        }
                        else
                        {
                            Console.WriteLine("Not enough rooms, an apartment can't have negitive rooms");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            return apartmentFourRoomCount;
        }

        static int ApartmentFive()
        {

            int userMainMenuChoise = -2;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("This is Appartment 5");
                Console.WriteLine("Choose 1 to ad a room");
                Console.WriteLine("Choose -1 to subtract a room");
                Console.WriteLine("Choose 0 to move back");
                Console.WriteLine("This apartment currently has " + apartmentFiveRoomCount + " rooms");
                Console.WriteLine("You have " + roomAmaunt + " rooms left");
                Console.Write("Write your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        if (roomAmaunt > 0)
                        {
                            apartmentFiveRoomCount++;

                            roomAmaunt--;
                        }
                        else
                        {
                            Console.WriteLine("Not enough spare rooms, subtract some rooms from other " +
                                "apartments to add here");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == -1)
                    {
                        if (apartmentFiveRoomCount > 0)
                        {
                            apartmentFiveRoomCount--;

                            roomAmaunt++;
                        }
                        else
                        {
                            Console.WriteLine("Not enough rooms, an apartment can't have negitive rooms");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            return apartmentFiveRoomCount;
        }

        static int ApartmentSix()
        {

            int userMainMenuChoise = -2;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("This is Appartment 6");
                Console.WriteLine("Choose 1 to ad a room");
                Console.WriteLine("Choose -1 to subtract a room");
                Console.WriteLine("Choose 0 to move back");
                Console.WriteLine("This apartment currently has " + apartmentSixRoomCount + " rooms");
                Console.WriteLine("You have " + roomAmaunt + " rooms left");
                Console.Write("Write your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        if (roomAmaunt > 0)
                        {
                            apartmentSixRoomCount++;

                            roomAmaunt--;
                        }
                        else
                        {
                            Console.WriteLine("Not enough spare rooms, subtract some rooms from other " +
                                "apartments to add here");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == -1)
                    {
                        if (apartmentSixRoomCount > 0)
                        {
                            apartmentSixRoomCount--;

                            roomAmaunt++;
                        }
                        else
                        {
                            Console.WriteLine("Not enough rooms, an apartment can't have negitive rooms");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            return apartmentSixRoomCount;
        }

        static int ApartmentSeven()
        {

            int userMainMenuChoise = -2;
            bool userMainMenuChoiseCheck;

            do
            {
                Console.Clear();
                Console.WriteLine("This is Appartment 7");
                Console.WriteLine("Choose 1 to ad a room");
                Console.WriteLine("Choose -1 to subtract a room");
                Console.WriteLine("Choose 0 to move back");
                Console.WriteLine("This apartment currently has " + apartmentSevenRoomCount + " rooms");
                Console.WriteLine("You have " + roomAmaunt + " rooms left");
                Console.Write("Write your choise: ");

                userMainMenuChoiseCheck = int.TryParse(Console.ReadLine(), out userMainMenuChoise);

                if (userMainMenuChoiseCheck)
                {
                    if (userMainMenuChoise == 1)
                    {
                        if (roomAmaunt > 0)
                        {
                            apartmentSevenRoomCount++;

                            roomAmaunt--;
                        }
                        else
                        {
                            Console.WriteLine("Not enough spare rooms, subtract some rooms from other " +
                                "apartments to add here");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == -1)
                    {
                        if (apartmentSevenRoomCount > 0)
                        {
                            apartmentSevenRoomCount--;

                            roomAmaunt++;
                        }
                        else
                        {
                            Console.WriteLine("Not enough rooms, an apartment can't have negitive rooms");
                            Console.ReadLine();
                        }
                    }
                    else if (userMainMenuChoise == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Was unable to find that choise");
                        Console.ReadLine();
                    }
                }
                else
                {
                    userMainMenuChoise = -1;

                    Console.WriteLine("Nubers only, try again");
                    Console.ReadLine();
                }
            }
            while (userMainMenuChoise != 0);

            return apartmentSevenRoomCount;
        }
    }
}
