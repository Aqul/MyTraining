using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    /*
     ВВодим 2 числа, после вводим число соответствующее дейтсвию ( 1-сложение, 2-вычитание...)
     после выводим результат на экран.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // ввод чисел и выбор действия
            Console.WriteLine("Введите 2 числа: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int action = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            //производим выбранную операцию, выводим на экран
            switch (action)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    result = num1 + num2;
                    Console.WriteLine($"Результат операции: {result}");
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    result = num1 - num2;
                    Console.WriteLine($"Результат операции: {result}");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    result = num1 * num2;
                    Console.WriteLine($"Результат операции: {result}");
                    break;
                default:
                    Console.WriteLine("Неверное число");
                    break;
            }
            Console.ReadKey();
        }
    }
}
