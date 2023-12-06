using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("the cube of the number you entered is ");
            Console.WriteLine(Cube(userInput));

            Console.ReadLine(); 

        }

        static int Cube(int x)
        {
          return x * x * x;
        }
    }
}
