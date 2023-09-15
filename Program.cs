using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter numbers to check its prime or or not : ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // int rem = 0;

            /*  for (int i = 1; i <= userNumber; i++)
              {
                  if (userNumber % i == 0)
                 {
                     rem++;
                  }
              }
              if (rem == 2)
             {
                  Console.WriteLine("your number is prime number");
              }
              else
              {
                Console.WriteLine("your number is not prime number");
              }*/
           
            for (int primeNumbers = 1; primeNumbers <= userNumber; primeNumbers++)
            {
                int rem = 0;

                for (int i = 1 ; i <= primeNumbers; i++)
                {
                    if (primeNumbers%i==0)
                    {
                        rem++;
                    }
                }
                if (rem == 2) 
                {
                    Console.WriteLine(primeNumbers);
                }
            }
            Console.ReadLine();
        }
    }
}
