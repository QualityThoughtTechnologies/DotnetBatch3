using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1,number2;
            Console.WriteLine("Enter Number1");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number2");
            number2 = int.Parse(Console.ReadLine());

            int size = (number2 - number1) / 2;
            size++;
            int[] evenNumbers = new int[size];
            int evenNumbersIndex = 0;

            for(int index=number1;index<=number2;index++)
            {
                if(index%2==0)
                {
                    evenNumbers[evenNumbersIndex] = index;
                    evenNumbersIndex++;
                }
            }
            double average = 0;

            for(int index=0;index<evenNumbers.Length;index++)
            {
                //if(evenNumbers[index]!=0)
                Console.WriteLine(evenNumbers[index]);
                average += evenNumbers[index];
            }
            average /= evenNumbers.Length;
            Console.WriteLine( average);
        }
    }
}
