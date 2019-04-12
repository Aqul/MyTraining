using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_switch_tern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // data input
            Console.Write("Сейчас будет произведено сравнение x и y \nВведите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            // x and y compare
            if (x > y)
            {
                Console.WriteLine("x больше чем y");
            }
            else
            {
                if (x < y)
                {
                    Console.WriteLine("Y больше чем X");
                }
                else
                {
                    Console.WriteLine("Y равен X");
                }
            }
            // if x > 10 and x < 5 == true
            if (x < 10 & x > 5)
            {
                Console.WriteLine($"Число X={x} больше пяти и меньше десяти");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
            // if x == 5 or x == 10 then write this
            switch (x)
            {
                case 5:
                    Console.WriteLine("X равен пяти");
                    break;
                case 10:
                    Console.WriteLine("Х равен десяти");
                    break;
                default:
                    Console.WriteLine("Неизвестное число");
                    break;
            }
            Console.Read();
        }
    }
}
