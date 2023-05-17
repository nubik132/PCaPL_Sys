using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    class Prog
    {
        static public void bebra()
        {
            Console.Write("x=");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Один");
                    break;
                case 2:
                    Console.WriteLine("Четыре");
                    break;
                case 3:
                    Console.WriteLine("Девять");
                    break;
                case 4:
                    Console.WriteLine("Шестнадцать");
                    break;
                case 5:
                    Console.WriteLine("Двадцать пять");
                    break;
                default:
                    Console.Write("x вне диапазона 1-5");
                    break;
            }
        }
    }
}
