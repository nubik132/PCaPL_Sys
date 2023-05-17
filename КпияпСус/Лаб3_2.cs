using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Prog
    {
        static public void bebra()
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x < 10)
            {
                Console.WriteLine("x<10");
            }if (x <50 && x > 30)
            {
                Console.WriteLine("x в диапозон входит");
            }
            else
            {
                Console.WriteLine("x в диапозон не входит");

            }
        }
    }
}
