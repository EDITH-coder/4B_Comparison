using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsMultiplicative(3));
            Console.WriteLine(IsMultiplicative(14));
            Console.WriteLine(IsMultiplicative(12));
            Console.WriteLine(IsMultiplicative(37));

            Console.ReadLine();

        }
        //Method to check if a given positive number is a multiple of 3 or 7.
        public static bool IsMultiplicative(int num1)
        {
            if(num1 % 3 ==0 || num1 % 7==0)
            {
                return true;
            }
            return false;
        }
    }
}
