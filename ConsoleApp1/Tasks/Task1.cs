using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tasks
{
    //Задача вычисления факториала
    static class Task1
    {
        private static int Factorial(int number)
        {
            if (number != 1)
                return Factorial(number - 1) * number;
            else
                return 1;
        }
        public static void Solution()
        {
            Console.WriteLine(Factorial(5).ToString());
        }
    }
}
