using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Student
    {
        private string name;
        private string address, phoneNumber;

        public void EnterDetails(string name,string address,string phoneNumber)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            
        }

        public void DisplayDetails()
        {
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(phoneNumber);
        }


    }
}
