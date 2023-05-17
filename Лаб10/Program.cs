namespace Лаб10
{
	class Program
	{
		static void Main()
		{
			Human a = new(30, "Sasha", 180);
			a.Print();
			Student b = new(3, 17, "Vlad", 170);
			b.Print();
		}
	}
	class Human
	{
		public int age;
		public string name;
		public int tall;
		public Human (int age, string name, int tall)
		{
			this.age = age;
			this.name = name;
			this.tall = tall;
		}
		public virtual void Print()
		{
			Console.WriteLine("Возраст " + age);
			Console.WriteLine("Имя " + name);
			Console.WriteLine("Рост " + tall);
            Console.WriteLine("----------------------");
        }
	}
	class Student : Human
	{
		public int curs;
		public Student(int curs, int age, string name, int tall) : base(age, name, tall)
		{
			this.curs = curs;
		}
		public override void Print()
		{
            Console.WriteLine("Возраст " + age);
            Console.WriteLine("Имя " + name);
            Console.WriteLine("Рост " + tall);
            Console.WriteLine("Курс " + curs);
		}
	}
    }