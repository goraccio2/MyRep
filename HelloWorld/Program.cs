using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var input = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your number is " + input);

        }
    }
}
