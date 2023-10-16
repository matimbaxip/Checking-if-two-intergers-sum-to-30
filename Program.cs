using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_if_two_intergers_sum_to_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool result = (num1 == 30 || num2 == 30) || (num1 + num2 == 30);

            Console.WriteLine("Result: " + result);

        }
    }
}
