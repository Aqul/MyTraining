using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
            // перебор массива
            foreach (int i in mas)
            {
                Console.Write(i+" ");
            }
            int length = mas.Length; // длина массива
            // длина первого измерения
            int dimension = mas.GetUpperBound(0) + 1;
            Console.WriteLine("Длина массива и длина первого измерения: "+length+" и "+dimension);
            Console.ReadKey();
            */
            // Вводим num числ в одномерный массив, потом сортируем их
            // узнаем сколько чисел нужно ввести, вводим их, помещаем в массив
            Console.WriteLine("How many numbers will u enter? ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] mass= new int[num];
            Console.WriteLine("Okey let's enter numbers ");
            for ( int i = 0; i < num; i++ )
            {
                Console.WriteLine($"{i+1} numbers: ");
                int x = Convert.ToInt32(Console.ReadLine());
                mass[i] = x;
            }
            for (int j = 0; j < num; j++)
            {
                for(int y = 0; y < num; y++)
                {
                    if (mass[j] > mass[y])
                    {
                        int buf = mass[j];
                        mass[j] = mass[y];
                        mass[y] = buf;
                    }
                }
            }
            foreach (int all in mass)
            {
                Console.Write(all + " ");
            }
            Console.ReadKey();
        }
    }
}
