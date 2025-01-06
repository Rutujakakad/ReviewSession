// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace UnitTestReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num:");
            int num = int.Parse(Console.ReadLine());
            Program obj = new Program();
           
        }
          public static bool IsPrimeNo(int num, bool expected)
          {
            if (num > 0)
            {
                num = num % 2;
               
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Number is not prime");
                    }
                
            }
            else
            {
                Console.WriteLine("Number is prime");
            }
          }
           

        
        

         
        
        
            
        
    }
}