using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite summus vklada: ");
            Double vklad = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite koli4estvo mesyacev vklada: ");
            int mouth = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < mouth; i++)
            {
                if (vklad < 100)
                {
                    vklad += vklad * 0.05;
                }
                else if (vklad > 200)
                {
                    vklad += vklad * 0.1;
                }
                else
                {
                    vklad += vklad * 0.07;
                }
            }
            vklad += 15;
            Console.WriteLine($"Summa vklada za {mouth} mesyacev sostavila {vklad}");
            Console.ReadKey();
        }
    }
}
