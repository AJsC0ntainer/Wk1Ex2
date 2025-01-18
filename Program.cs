using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("INFORMATION INPUT");

            //First Name User Input
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Last Name User Input
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            //Age User Input
            Console.Write("What is your age? ");
            string age = Console.ReadLine();

            //Color User Input
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();

            //Output
            Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} old and your favorite color is {color}.");

        }
    }
}

