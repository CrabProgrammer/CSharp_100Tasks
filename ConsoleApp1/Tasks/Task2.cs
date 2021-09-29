using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tasks
{
    class Task2
    {
        private static int Factorial(int number)
        {
            int current = 1;
            for(int i=1;i<=number;i++)
            {
                current *= i;
            }
            return current;
        }
        public static void Solution()
        {
            int i = 1;
            int maxFactorial=1;
            try
            {
                while (true)
                {
                    if (checked(maxFactorial * i) > Int32.MaxValue || checked(maxFactorial * i) < Int32.MinValue || i > 20)
                    {
                        break;
                    }
                    i++;
                    maxFactorial *= i;
                }
            }
            catch { }
            Console.WriteLine(i.ToString() + " " + maxFactorial.ToString()) ;
        }
    }
}
