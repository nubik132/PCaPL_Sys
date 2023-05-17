using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab8
{
    public enum Month
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }
    class MyClass
	{
		static void Main(string[] args)
		{
			MyStruct alesha = new MyStruct("бара", "бере", 10);
			MyStruct dobrinya = new MyStruct { a = "bara", b = "bere", c = 10 };
			alesha.Print();
			dobrinya.Print();
			for (int i = 0; i < 12; i++)
			{
				PrintMessage((Month)i);
			}
		}
        

        public static void PrintMessage(Month month)
		{
			switch (month)
			{
				case Month.January:
					Console.WriteLine("Январь");
					break;
				case Month.February:
					Console.WriteLine("Февраль");
					break;
				case Month.March:
					Console.WriteLine("Март");
					break;
				case Month.April:
					Console.WriteLine("Апрель");
					break;
                case Month.May:
                    Console.WriteLine("Май");
                    break;
                case Month.June:
                    Console.WriteLine("Июнь");
                    break;
                case Month.July:
                    Console.WriteLine("Июль");
                    break;
                case Month.August:
                    Console.WriteLine("Август");
                    break;
                case Month.September:
                    Console.WriteLine("Сентябрь");
                    break;
                case Month.October:
                    Console.WriteLine("Октябрь");
                    break;
                case Month.November:
                    Console.WriteLine("Ноябрь");
                    break;
                case Month.December:
                    Console.WriteLine("Декабрь");
                    break;
            }

		}
		struct MyStruct
		{
			public string a, b;
			public int c;
			public MyStruct(string a, string b, int c)
			{
				this.a = a;
				this.b = b;
				this.c = c;
			}
			public void Print()
			{
				Console.WriteLine($"{a},{b},{c}");
			}

		}
	

	}
}