using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, укажи некоторые данные о себе,пожалуйства.");
            Console.WriteLine("Твое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Твой Возраст: ");
            // readline всегда считывает строку(string) после этого мы можем конвертировать в другие типы
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ох ты мелкий пиздюк {0} вали от сюда", name); //тут знак $ не нужен, для вывода name
            Console.Read();
            
        }
    }
}
