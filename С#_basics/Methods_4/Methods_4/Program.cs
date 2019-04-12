using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_4
{
    class Program
    {
        // ref - передача по ссылке
        // out - выходное значение
        static void Display(int r, params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            result *= r;
            Console.WriteLine(result);
        }
        static void Summa (int x, ref int y, out int z)
        {
            z = x + y;
        }
        static void Main(string[] args)
        {
            int baby = 14;
            int result;
            Summa(12, ref baby,out result);
            Console.WriteLine(result);
            Display(2,2,3);
            Console.ReadLine();
        }
    }
}
