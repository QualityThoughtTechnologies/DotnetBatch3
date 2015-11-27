using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students=new Student[3];
            for(int index=0;index<students.Length;index++)
            {
                Student s = new Student();
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter phone Number");
                string phoneNumber = Console.ReadLine();
                s.EnterDetails(name, address, phoneNumber);
                students[index] = s;
            }
            


            Console.WriteLine("Displaying details");
            for(int index=0;index<students.Length;index++)
            {
                Student s = students[index];
                s.DisplayDetails();
            }
            
        }
    }
}
