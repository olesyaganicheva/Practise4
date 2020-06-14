using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_Задание_3_60а
{
    class Практика_Задание_4_60а
    {
        static void Main()
        {
            double e = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine(Sum(e));

            Console.ReadKey();
        }
        public static double Sum(double e)
        {
            double a = 1.0, b = 25.0;
            double r = 0, y = 0;

            do
            {
                r += y;
                y = 1.0 / (a + b);
                a *= 4;
                b *= 5;
            } while (y > e);
            return r;
        }
    }
}
