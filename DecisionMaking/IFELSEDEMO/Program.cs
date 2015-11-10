using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFELSEDEMO
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Program to print the words when the number is entered
            //e.g. input =0 output=zero
 
            //Writing twith consecutive if statements

            int number = 0;

            //if (number == 0)
            //{
            //    Console.WriteLine("Zero");
            //}
            //if (number == 1)
            //{
            //    Console.WriteLine("One");
            //}
            //if (number == 2)
            //{
            //    Console.WriteLine("Two");
            //}
            //if (number == 3)
            //{
            //    Console.WriteLine("Three");
            //}

            // next solution to above problem where all the ifs are executed
            // is If else
            //if(number==0)
            //{
            //    Console.WriteLine("Zero");
            //}
            //else
            //{
            //    if(number==1)
            //    {
            //        Console.WriteLine("one");
            //    }
            //    else
            //    {
            //        if(number==2)
            //        {
            //            Console.WriteLine("Two");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Three");
            //        }
            //    }
            //}

            // Solution to above complicated if else (nested) is if else if

            if(number==0)
            {
                Console.WriteLine("Zero");
            }
            else if (number == 1)
            {
                Console.WriteLine("One");
            }
            else if (number==2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("Three");
            }

            //Conditional Operator

            string myMessage = number % 2 == 0 ? "Even" : "Odd";

            // The equivalent if else statement is 
            //if(number%2==0)
            //{
            //    message = "Even";
            //}
            //else
            //{
            //    message = "Odd";
            //}
            Console.WriteLine(myMessage);

        }
    }
}
