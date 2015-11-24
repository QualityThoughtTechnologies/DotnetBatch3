using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = GetNumberFromConsole();
            int n2 = GetNumberFromConsole();

            for(int index=n1;index<n2;index++)
            {
                if (IsPrime(index))
                {
                    Console.WriteLine(index);
                }

            }

        }

        private static bool IsPrime(int number)
        {
            bool isPrime = true;
            for (int index = 2; index < number; index++)
            {
                if (number % index == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        static int GetNumberFromConsole()
        {
            Console.WriteLine("Enter Number");
            return int.Parse(Console.ReadLine());
        }
    }
}
