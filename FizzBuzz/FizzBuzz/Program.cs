using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Billy Scrimsher, 3/10/2014

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /**
             * This application is used in many interviews. 
             * We will ask the user for a an Integer
             * We then will step through counting up to that Integer, 
             * and for every number that is a multiple of 3, we will output "Fizz".
             * For every number that is a multiple of 5, we output "Buzz".
             * For every number that is BOTH, we will output "FizzBuzz".
             */

            int promptNum;

            
            Console.WriteLine("Hi! Please enter an Integer!");
            promptNum = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(promptNum);

                for( int i = 1; i <= promptNum; i++)
                {
                    if (i%3 == 0 && i%5 == 0)
                    {
                        Console.WriteLine("FizzBuzz!");
                    }

                    else if ((i%3) == 0)
                    {
                        //Number goes into 3!
                        Console.WriteLine("Fizz!");
                    }

                    else if ((i % 5) == 0)
                    {
                        Console.WriteLine("Buzz!");
                    }

                    else 
                    {
                        Console.WriteLine("Writing current number... " + i);
                    }
             
                }

                Console.ReadLine();//Pause the System.
        }
    }
}
