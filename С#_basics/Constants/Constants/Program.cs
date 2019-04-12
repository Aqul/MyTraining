using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    /*
     * Литералы представляют неизменяемые значения (иногда их еще называют константами).
     * Литералы можно передавать переменным в качестве значения. Литералы бывают логическими,
     * целочисленными, вещественными, символьными и строчными. И отдельный литерал представляет ключевое слово null.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // логические константы
            Console.WriteLine(true);
            Console.WriteLine(false);
            // целочисленные константы
            Console.WriteLine(-11);
            Console.WriteLine(60);
            //целовчисленные константы в двочиной форме
            Console.WriteLine(0b11); // 3
            //целовчисленные константы в шестнадцатеричной форме
            Console.WriteLine(0x0A); //10
            //Вещественные литералы
            Console.WriteLine(3.14);
            Console.WriteLine(3.2e3); // 3.2 * 10^3 = 3200
            Console.WriteLine(1.2e-1); // 1.2 * 10^-1 = 0.12
            //Символьные литералы (одинарные ковычки)
            Console.WriteLine('G');
            Console.WriteLine('\x5a'); // ASCII
            Console.WriteLine('\u0420'); // UNICODE
            //Строчные литералы (двойные ковычки)
            Console.WriteLine("Hello, \n \" World!!!\"!"); // перенос строки и вывод ковычек
            Console.Read();
        }
    }
}
