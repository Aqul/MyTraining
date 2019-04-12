using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool только false или true System.Boolean
            bool alive = true;
            bool isDead = false;
            /*
             * byte 0..255 1байт System.Byte
             * sbyte -128..127 1байт System.SByte
             * short -32768..32767 2байта System.Int16
             * ushort 0..65535 2байта System.UInt16
             * int -2147483648..2147483647 4байта System.Int32
             * uint 0..4294967295 4байта System.UInt32
             * long –9 223 372 036 854 775 808..9 223 372 036 854 775 807  8байт System.Int64
             * ulong 0..18 446 744 073 709 551 615 и занимает 8 байт System.UInt64.
             * 
             * числа с плавающей точкой: float, double, decimal
             * для флоат и децимал обязателен суффикс f/F и m/M
             * 
             * object - может хранить любой тип данных
             * 
             * можно невно типизировать с помощью var
             */
            object cat = "Mister Whiskers";
            var age = 11;
            var life = true;
            if (age > 7)
                Console.WriteLine($"Cat name is {cat}");
            if (life == alive && life != isDead)
                Console.WriteLine("and he is alive");
            Console.Read();

        }
    }
}
