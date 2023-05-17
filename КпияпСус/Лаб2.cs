using System;

namespace Lab2
{
    class Prog
    {
        public void berba()
        {
            Console.WriteLine("Введите x");
            double x= Convert.ToDouble(Console.ReadLine());
            double z = Math.Sin(x) + Math.Pow(x, 3) + 1;
            Console.WriteLine("Ответ=" + z);
        }
    }
}