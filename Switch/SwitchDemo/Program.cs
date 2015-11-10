using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            while (isValid)
            {
                Console.WriteLine("Enter number from 0 to 9");
                string value = Console.ReadLine();

                int number = int.Parse(value);
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    default:
                        Console.WriteLine("Other Number");
                        break;
                }
                Console.WriteLine("Do you want to continue? Press Y to Continue any key to Exit");
                string input = Console.ReadLine();
                if(input!="Y")
                {
                    isValid=false;
                }
            }
        }
    }
}
