﻿using System;

namespace prog1783F20_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string fullName;
            string address;
            string areaLocation; //city, province, postal code
            string instructions;
            double phoneNum;

            decimal[] reciept = { 0, 0, 0, 0, 0 };

            Console.ForegroundColor = ConsoleColor.Magenta;//changes color of text
            //intro to project
            Console.WriteLine("Welcome to Arnold's Amazing Eats. This program is designed to take customers food orders and process them. " +
                "After the users personal information is taken along with there order, the recipt will display back" +
                "showing your order. Let's get started. Today there are two specials going on!");

            //Steps to take customers information
            Console.WriteLine("Please provide your first and last name");
            fullName = Console.ReadLine();
            Console.WriteLine("Please provide your address");
            address = Console.ReadLine();
            Console.WriteLine("Please provide your city, province, and postal code");
            areaLocation = Console.ReadLine();
            Console.WriteLine("Please provide a phone number we can reach you at");
            phoneNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please provide special instructions for deliveries from this address");
            instructions = Console.ReadLine();

            //begin order
            Console.WriteLine("Great! Now that we have your delivery information lets get into ordering some food");
            double choice;
            do
            {
                Console.WriteLine("Select option 1 or 2");
                Console.WriteLine("1) Burger combo | 15.99 (Burger with a side of fries and choice of drink)");
                Console.WriteLine("2) Steak combo | 25.50 (Steak how you like it with a side of veggies and baked potato with choice of drink)");
                Console.WriteLine("");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1) //if user selects option 1 then execute method
                {
                    reciept = BurgerCombo();
                    break;
                }
                else if (choice == 2) //if user selects option 2 then execute method
                {
                    reciept = SteakCombo();
                    break;
                }
                else //try again
                {
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine("Please specify from the menu");
                }


            } while (choice == 1 || choice == 2);

            Console.Clear();
            //Data recipt of the order
            Console.WriteLine("");
            Console.WriteLine(fullName);
            Console.WriteLine("");
            Console.WriteLine(address);
            Console.WriteLine("");
            Console.WriteLine(areaLocation);
            Console.WriteLine("");
            Console.WriteLine(phoneNum);
            Console.WriteLine("");
            Console.WriteLine(instructions);
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("Item Amt: " + reciept[3]);
            Console.WriteLine("Name of the dinner: " + choice);
            Console.WriteLine("");
            Console.WriteLine("10% student savings: " + reciept[1]);
            Console.WriteLine("Sub Total: " + reciept[4]);
            Console.WriteLine("Tax (13%): " + reciept[2]);
            Console.WriteLine("");
            Console.WriteLine("TOTAL: " + reciept[0]);
            Console.ReadKey(true);
        }


        public static decimal[] BurgerCombo()
        {
            int itemAmount = 0;
            string Student;

            decimal HST = 1.13M;
            decimal Total = 0;
            decimal savings = 0;
            decimal subTotal = 0;
            decimal taxAmount = 0;
            decimal priceComboOne = 0;

            Console.WriteLine("How many of those meals are being ordered today?"); //ask how many they want
            string numOfOrders = Console.ReadLine(); //converting string to int
            itemAmount = int.Parse(numOfOrders);
            Console.WriteLine("Is this correct? (Y/N): " + itemAmount); //confirm amount
            string answer = Console.ReadLine();

            while (answer == "y" || answer == "Y") //calculations will take place once order is confirmed
            {
                Console.WriteLine("Are you a student? (Y/N)"); //if the customer is a student then a discount will apply
                Student = Console.ReadLine();

                if (Student == "y" || Student == "Y") //if student do the following
                {
                    decimal d = 15.99M; //price of option 1
                    priceComboOne = d * itemAmount;
                    savings = priceComboOne * 0.1M; //calculate discount savings
                    savings = Math.Round(savings, 2); //round 2 decimal places
                    subTotal = priceComboOne - savings; //sub total is a result from the price of the item minus the discount
                    taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
                    taxAmount = Math.Round(taxAmount, 2);
                    Total = subTotal + taxAmount;
                    break;

                }
                else if (Student == "n" || Student == "N") //if not a student do the following
                {
                    decimal d = 15.99M; //price of option 1
                    subTotal = d * itemAmount; //sub total is the price of the item 
                    taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
                    taxAmount = Math.Round(taxAmount, 2);
                    Total = subTotal + taxAmount;
                    break;

                }
            }
            decimal[] arr2 = { Total, savings, taxAmount, itemAmount, subTotal };
            return arr2;
        }

        public static decimal[] SteakCombo()
        {
            int itemAmount = 0;
            string Student;

            decimal HST = 1.13M;
            decimal Total = 0;
            decimal savings = 0;
            decimal subTotal = 0;
            decimal taxAmount = 0;
            decimal priceComboTwo = 0;

            Console.WriteLine("How many of those meals are being ordered today?"); //ask how many they want
            string numOfOrders = Console.ReadLine(); //converting string to int
            itemAmount = int.Parse(numOfOrders);
            Console.WriteLine("Is this correct? (Y/N): " + itemAmount); //confirm amount
            string answer = Console.ReadLine();

            while (answer == "y" || answer == "Y") //calculations will take place once order is confirmed
            {
                Console.WriteLine("Are you a student? (Y/N)");
                Student = Console.ReadLine();

                if (Student == "y" || Student == "Y") //if student do the following
                {
                    decimal d = 25.50M; //price of option 2
                    priceComboTwo = d * itemAmount;
                    savings = priceComboTwo * 0.1M; //calculate discount savings
                    savings = Math.Round(savings, 2); //round 2 decimal places
                    subTotal = priceComboTwo - savings; //sub total is a result from the price of the item minus the discount
                    taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
                    taxAmount = Math.Round(taxAmount, 2);
                    Total = subTotal + taxAmount;
                    break;

                }
                else if (Student == "n" || Student == "N") //if not a student do the following
                {
                    decimal d = 25.50M; //price of option 2
                    subTotal = d * itemAmount; //sub total is the price of the item 
                    taxAmount = (subTotal * HST) - subTotal; //calculate the exact tax amount in decimal format and round
                    taxAmount = Math.Round(taxAmount, 2);
                    Total = subTotal + taxAmount;
                    break;

                }
            }
            decimal[] arr2 = { Total, savings, taxAmount, itemAmount, subTotal };
            return arr2;
        }
    }
}