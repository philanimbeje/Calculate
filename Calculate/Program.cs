using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("enter a simple sum");
            var sum = Console.ReadLine();

            var calculation = new Calculation(sum);
            var result = calculation.GetResult();
            Console.WriteLine("The result is: "+ result);

            Console.ReadKey();
        }
    }
}
