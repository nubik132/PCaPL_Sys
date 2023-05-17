using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_5
{
    class Prog
    {
        static public void bebra()
        {
            double x = 1;
            while (1 / x > 0.0023)
            {
                Console.WriteLine("{0}:{1}", x, 1 / x);
                x++;
            }
            Console.WriteLine(x);
        }
    }
}
