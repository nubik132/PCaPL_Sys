using System.Xml.Linq;
using System;

namespace Лаб11
{
    class Program
    {
        static void Main()
        {
            Avtobus[] bus = new Avtobus[3];
            for (int i = 0; i < bus.Length; i++)
                bus[i] = new Avtobus(3 - i);
            Console.WriteLine("До сортировки:");
            Print(bus);
            Console.WriteLine("После сортировки:");
            Array.Sort(bus);
            Print(bus);
        }
        static void Print(Avtobus[] bus)
        {
            foreach (Avtobus item in bus)
                item.Info();
        }
    }

    interface IGetNum
    {
        int GetNum();
    }
    interface IInfo
    {
        void Info();
    }
    class Avtobus : IGetNum, IInfo, IComparable
    {
        int Busnumber;
        public Avtobus(int busnumber)
        {
            Busnumber = busnumber;
        }
        public int CompareTo(object? num)
        {
            if (num is Avtobus avtobus) return Busnumber.CompareTo(avtobus.GetNum());
            else throw new ArgumentException("Некорректное значение параметра");

        }
        public int GetNum()
        {
            return Busnumber;
        }
        public void Info()
        {
            Console.WriteLine("Желтый маленький автобус с номером " + Busnumber);
        }
    }
}
