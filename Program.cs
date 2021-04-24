using System;

namespace Week2_Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            Console.WriteLine("Give me the temperature in degrees Farenheit.");
            double tempF = double.Parse(Console.ReadLine());
            double tempC = Math.Round(((tempF - 32) * 5 / 9), 2);

           Console.WriteLine($"{tempF} degrees equals {tempC} degrees Celsius\r\n");

            //Exercise 2

            Console.WriteLine("How much does your product cost?");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the sales tax in your state?");
            double tax = Convert.ToDouble(Console.ReadLine());
            double total = Math.Round((((tax / 100) + 1) * cost), 2);
            Console.WriteLine($"The total cost of your product with tax will be ${total}\r\n");

            //Exercise 3

            Console.WriteLine("What's the bill?");
            double bill = double.Parse(Console.ReadLine());
            Console.WriteLine("What percent would you like to tip?");
            double tip = Convert.ToDouble(Console.ReadLine());
            if (tip >= 15)
            {
                double billTotal = (((tip / 100) * bill) + bill);
                Console.WriteLine($"Your total bill is ${billTotal}\r\n");
            }

            else
            {
                Console.WriteLine("C'mon. That's not enough.");

            }

            //Exercise 4

            Console.WriteLine("What's the bill?");
            double bill2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many people are splitting the bill?");
            int people = Convert.ToInt32(Console.ReadLine());
            double billTotal2 = (bill2 / people);

            Console.WriteLine($"Each person owes ${billTotal2}");




            Console.ReadLine();
            
            

        }
    }
}
