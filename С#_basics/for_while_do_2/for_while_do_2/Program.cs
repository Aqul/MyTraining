using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_while_do_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // входные данные
            Console.Write("Введите сумму вклада: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество месяцев вклада: ");
            int mouth = Convert.ToInt32(Console.ReadLine());
            /*
            // расчет вклада deposit после mouth месяцев под ставкой 7% в месяц
            for (int x = 0; x < mouth; x++)
            {
                deposit += deposit * 0.07m;
            }
            Console.WriteLine($"Ваш общий депосит равен: {deposit}");
            */
            // тоже самое только через while
            while (mouth != 0)
            {
                deposit += deposit * 0.07m;
                mouth--;
            }
            Console.WriteLine($"Ваш общий депозит за {mouth} месяцев равен {deposit}");
            Console.ReadKey();
        }
    }
}
