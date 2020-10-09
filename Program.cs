using System;

namespace prog1783F20_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            string fullName;
            string address;
            string areaLocation;
            string instructions;
            double phone;

            //welcome
            Console.WriteLine("Welcome to Arnold's Amazing Eats! This program helps you order the best food in Waterloo and have it delivered to your door!");
        
        //customer info
        Console.WriteLine("Enter your first and last name");
            fullName = Console.ReadLine();

            Console.WriteLine("Enter your address");
            address = Console.ReadLine();

            Console.WriteLine("Enter your city, province, and postal code");
            areaLocation = Console.ReadLine();

            Console.WriteLine("Enter phone number");
            phone = double.Parse(Console.ReadLine());

        Console.WriteLine("Please provide special instructions for deliveries from this address");
            instructions = Console.ReadLine();

            Console.WriteLine("Let's order some food!");
            double choice;
            
            
                
            
        }
    }
}
