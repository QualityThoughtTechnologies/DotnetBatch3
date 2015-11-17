using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            //while (isValid)
            do
            {
                Console.WriteLine("enter numbers 0 to 9");
                String val = Console.ReadLine();
                int number = int.Parse(val);
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
                if (number % 2 == 0)
                {
                    Console.WriteLine("given number is even");
                }
                else
                {
                    Console.WriteLine("given number is odd");
                }
                isValid = false;
                Console.WriteLine("do you want to continue ?press Y to continue any key to exit");
                String input = Console.ReadLine();
                //if (input!="y")
                //{
                //    break;  
                //}
                isValid = (input == "Y" || input == "y");
            }while(isValid);
        }
    }
}

