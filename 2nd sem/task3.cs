using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printname
{
    class Program
    {
        static void Main(string[] args)
        {
            var fname = ("Input your First Name : ");
            var lname = ("Input your Last Name : ");
            Console.WriteLine( fname + lname); string firstName = "Milan";
            string lastName = "Humagain";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();
        }
      
        }
    }
}
