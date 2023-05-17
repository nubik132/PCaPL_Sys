using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    class Prog
    {
        static public void bebra()
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            double y = Convert.ToDouble(Console.ReadLine()) ;
            if (x == y)
            {
                Console.WriteLine("Равны");
            } else 
            {
                Console.WriteLine("Не равны");
            }
        }
    }
}
