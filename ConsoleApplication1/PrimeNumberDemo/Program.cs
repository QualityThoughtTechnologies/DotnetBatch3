using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter any number");
            //string input = Console.ReadLine();
            DateTime dt = DateTime.Now;
            int number=2;
            do
            {
                // = int.Parse(input);

                int index = 2;
                bool isPrime = true;
                while (index < number/2)
                {
                    if (number % index == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    index++;
                }

                if (isPrime)
                {
                   // Console.WriteLine("Prime Number");
                    Console.WriteLine(number);
                }
                else
                {
                   // Console.WriteLine("Not Prime NUmber");
                }
                number++;
            } while (number<100000);
            
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
                TimeSpan tp = DateTime.Now - dt;
            Console.WriteLine(tp.Seconds+"-"+tp.Milliseconds);
        }
    }
}
