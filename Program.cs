using System;

namespace Dice
{
    internal class Program
    {
        static void start()
        {
            Console.WriteLine("Would you like to convert to Celcius or Farenheit?");

            Console.WriteLine("1. Celcius -> Farenheit");
            Console.WriteLine("2. Farenheit -> Celcius");

            int option = Int32.Parse(Console.ReadLine());

            int[] allowed = { 1, 2 };

            if (Array.IndexOf(allowed, option) < 0)
            {
                Console.WriteLine("Invalid option!\n\n");
                start();
                return;
            }

            string readableFrom = option == 1 ? "Celcius" : "Farenheit";
            string readableTo = option == 1 ? "Farenheit" : "Celcius";

            Console.WriteLine($"Enter the temperature in {readableFrom}: ");

            int temp = Int32.Parse(Console.ReadLine());

            double converted;

            if (option == 1)
            {
                converted = CtoF(temp);
            }
            else
            {
                converted = FtoC(temp);
            }

            Console.WriteLine($"{temp}° in {readableFrom} is {converted}° {readableTo}");
        }

        static void Main(string[] args)
        {
            start();
        }

        static double CtoF(int value) { return (value * 1.8) + 32; }

        static double FtoC(int value) { return (value - 32) / 1.8; }
    }
}
