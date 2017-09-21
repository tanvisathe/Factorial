using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{ 
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                var input = GetNumberfromUser();
                bool validationStatus = UserInputValidation(input);
           
                if (validationStatus == true)
                {
                    long number = Convert.ToInt64(input);
                    long ansFactorial = CalculateFactorial(number);
                    Console.WriteLine($"{number} ! is {ansFactorial}");                    
                }            
                run = Continue();               
            }
           

        }
        public static string GetNumberfromUser()
        {
            Console.WriteLine("Please enter number between  1 and 10");
            var input = Console.ReadLine();
            return input;
        }
        public static bool UserInputValidation(string _input)
        {
            long value;
            try
            {
                long number = Convert.ToInt64(_input);
            
                if (string.IsNullOrWhiteSpace(_input) || string.IsNullOrWhiteSpace(_input))
                {
                    Console.WriteLine("Please enter valid numbers.");
                    return false;
                }
                else if (!Int64.TryParse(_input, out value))
                {
                    Console.WriteLine("Please enter Non-Zero and Positive numbers as input and try again.");
                    return false;
                }
                else if (value < 1 || value > 10)
                {
                    Console.WriteLine("Please enter numbers between 1 and 10. ");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType() }  means  {ex.Message}");
                return false;

            }
        
        }

        public static long CalculateFactorial(long number)
        {
            int fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
            
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you want to continue?(y/n)");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goAhead;
            if (input == "y")
            {
                goAhead = true;

            }
            else if (input == "n")
            {
                goAhead = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, please try again");
                goAhead = Continue();
            }
            return goAhead;
        }


    }
}
