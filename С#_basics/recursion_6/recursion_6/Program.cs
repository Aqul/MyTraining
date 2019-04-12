using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_6
{
    class Program
    {
        /*
         * рекурсивная функция - функция вызывающая сама себя примеры - факториал, числа фибоначи
         */
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1) ;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
            Console.ReadKey();
        }
    }
}
