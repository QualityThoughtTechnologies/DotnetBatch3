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

            PrimeNumbers(n1, n2);

            EvenNumbers(n1, n2);
            
            Factors(n1, n2);

        }

        private static void Factors(int n1, int n2)
        {
            int number = GetNumberFromConsole();
            Console.WriteLine("Factors");
            for (int index = n1; index < n2; index++)
            {
                if (index % number == 0)
                {
                    Console.WriteLine(index);
                }
            }
        }

        private static void EvenNumbers(int n1, int n2)
        {
            Console.WriteLine("Even Numbers");
            for(int index=n1;index<n2;index++)
            {
                if(index%2==0)
                {
                    Console.WriteLine(index);
                }
            }
        }

        private static void PrimeNumbers(int n1, int n2)
        {
            Console.WriteLine("Prime Numbers");
            for (int index = n1; index < n2; index++)
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
