using System;

namespace deliverable_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer between 0 and 100.");
                int input = int.Parse(Console.ReadLine());

                if ((input >= 0) && (input <= 100))
                {
                    Console.WriteLine("Do you want to see the even or odd numbers in this range?");
                    String series_name = Console.ReadLine();

                    if ((input >= 0) && (input <= 100) && (series_name == "even"))
                    {

                    Console.WriteLine("You've selected even. The even numbers between 0 and " + input.ToString() + ":");


                    int i = 1;
                    int even = 0;
                    while (even <= input)
                    {
                        Console.WriteLine(even.ToString() + " is an even number");
                        even = 2 * i;
                        i++;
                    }

                    Console.ReadKey();

                    }

                   if ((input >= 0) && (input <= 100) && (series_name == "odd"))
                   {
                    Console.WriteLine("You've selected odd. The odd numbers between 0 and " + input.ToString() + ":");

                    int j = 1;
                     int odd = 1;
                    while (odd <= input)
                    {
                        Console.WriteLine(odd.ToString() + " is an odd number");
                        odd = (2 * j) + 1;
                        j++;
                    }

                    Console.ReadKey();

                   }
                   else
                   {
                        Console.WriteLine("You entered an invalid series name. Please try again.");
                   }



                }
                else 
                {
                    Console.WriteLine("You entered an integer higher than 100. Please try again.");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);

                }

            }
            catch
            {
                /*
                 * 
                if ((input < 0) || (input > 100))
                {
                    Console.WriteLine("You entered an integer higher than 100. Please try again.");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                */
            }

               
        }
    }
}