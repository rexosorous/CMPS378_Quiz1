using System;

/*
Author: J-Zach Loke
Class: CMPS-378
Due Date: 09/23/2021 (makeup date due to illness)
Description:
    This program calculates the cost of a gas station purchase depending on the
    grade of gasoline, gallons of gas to purchase, and whether or not a carwash
    is to be included.
*/

namespace Quiz1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // prices
            const double REGULAR_GAS_PRICE = 4.39;
            const double MIDGRADE_GAS_PRICE = 4.59;
            const double PREMIUM_GAS_PRICE = 4.69;
            const double CARWASH_PRICE = 12;

            // collect inputs from the user
            Console.WriteLine("Regular\t\tMidgrade\tPremium");
            Console.WriteLine("$4.39\t\t$4.59\t\t$4.69");
            Console.Write("Your Type of Gas (R/M/P): ");
            char gastype = Convert.ToChar(Console.ReadLine());   // should be 'R', 'M', or 'P'
            Console.Write("Car Wash Today (Y/N): ");
            char carwash = Convert.ToChar(Console.ReadLine());  // should be 'Y' or 'N'
            Console.Write("How many gallons: ");
            double gallons = Convert.ToDouble(Console.ReadLine());

            // logic
            double total;
            double price = 0;
            if (gastype == 'R') {
                price = REGULAR_GAS_PRICE;
            }
            else if (gastype == 'M') {
                price = MIDGRADE_GAS_PRICE;
            }
            else if (gastype == 'P') {
                price = PREMIUM_GAS_PRICE;
            }

            total = price * gallons;
            if (carwash == 'Y') {
                total += CARWASH_PRICE;
            }

            // output results
            Console.WriteLine("\n");
            Console.WriteLine($"Your Total: ${total}");
            Console.WriteLine($"Gas Selected: {gastype}");
            Console.WriteLine($"Gallons: {gallons}");

            Console.ReadKey();
        }
    }
}