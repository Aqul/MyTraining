using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyName
{
    /*
        программа которая спрашивает у юзера имя 
        и выводит его на коносль
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: "); // asks name
            string name = Console.ReadLine(); // записывает в переменную стринг имя пользователя
            Console.WriteLine($"Привет {name}"); // выводит "привет"+имя
            Console.ReadLine(); // ожидание ввода
        }
    }
}
