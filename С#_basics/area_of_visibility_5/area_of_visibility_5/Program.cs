using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_visibility_5
{
    class Program
    {
        static int num = 16; // может использоваться в любом из методов класса
        static void Main(string[] args)
        {
            int num2 = 14; //num2 используется только в рамках метода
            {
                int z = num + num2; //z используется только в рамках блока кода
            }
            Console.WriteLine(num-num2);
            
            Console.ReadKey();
            //num = z;
            // неверно т.к. z не может быть тут использована
            //принцып матрешки , переменные стоящие в ирархии выше можно испольховать в иерархии ниже
        }
    }
}
