using System;

namespace CheckNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a Number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Entered Number is an Even Number");
                }
                else
                {
                    Console.WriteLine("Entered Number is an Odd Number");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

          
        }
    }
}
