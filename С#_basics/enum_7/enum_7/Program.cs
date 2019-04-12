using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_7
{
    // перечесление - набор связаных констант
    // каждое перечисление определяет нвоый тип данных
    enum Operation
    {
        add,
        substract,
        multiply,
        divide
    }
    class Program
    {
        static void ApplyOperation (double x, double y, Operation op)
        {
            double result = 0.0;
            switch (op)
            {
                case Operation.add:
                    result = x + y;
                    break;
                case Operation.substract:
                    result = x - y;
                    break;
                case Operation.multiply:
                    result = x * y;
                    break;
                case Operation.divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine(result);
        }
        enum Days
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        {
            Days day; // объявляем переменную day с типом данных Days
            day = Days.monday;
            Console.WriteLine(day); // monday
            Console.WriteLine((int)day); // 0
            ApplyOperation(15, 10, Operation.divide);
            Console.ReadKey();
        }
    }
}
