using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        public static int Calculate(int i)
        {
           
            return i;
        }
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write(++i + Calculate(i));

            Console.ReadKey();
        }
    }
}
