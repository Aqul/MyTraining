using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuple_8
{
    class Program
    {
        //функция возвращает кортеж(когда нужно вернуть 2 значения)
        static (int,int) cat()
        {
            int x = 14;
            int y = 15;
            return (x,y);
        }
        // функция возвращает кортеж и примает кортеж tuple и int num
        static (string,int) Belorus ((string,int) tuple, int num)
        {
            tuple.Item2 += num;
            return tuple;
        }
        static void Main(string[] args)
        {
            //неявное объявление кортежа + вывод значений
            var tuple = (5, 10);
            Console.WriteLine(tuple.Item1); // 5
            Console.WriteLine(tuple.Item2); // 10
            tuple.Item1 += 26;
            Console.WriteLine(tuple.Item1); // 31
            // присвоения значениям имен
            var tuple2 = (one: 1, two: 2);
            Console.WriteLine(tuple2.one);
            // создание кортежа без объявления его имени, со значениями в кортеже работаем как с обычными переменными
            var (name, age) = ("Whiskers", 1);
            Console.WriteLine(name);
            //присваиваем значения кортежу мистер из нашей функции
            var mister = cat();
            //выводим 1 элемент кортежа
            Console.WriteLine(mister.Item1);
            var zero = ("mister", 14);
            var timmi = Belorus(zero, 24);
            Console.WriteLine(timmi); // (mister, 38)
            Console.ReadKey();
        }
    }
}
