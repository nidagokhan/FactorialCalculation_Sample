using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculation.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(number));

            Console.ReadKey();
        }

        public static int Factorial(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
               return a*Factorial(a-1);
            }
        }
    }
}
