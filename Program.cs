using System;

namespace W4_Fridat_activity
{
 /*{1) Write a function called PrimeNumber() that takes one integer number as parameter.
 * The function will find if the number is prime or not and then print the results on the screen.
 */
    class Program
    {
        static void PrimeNumber(int num)
        {
            int i;
            int counter = 0;
            for (i = 1; i <= num; i = i + 1)
            {
                if (num % i == 0)
                {
                    counter = counter + 1;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("please enter integer");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            PrimeNumber(input);
            
        }
    }
}
