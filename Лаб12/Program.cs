namespace Лаб12
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
                int[] values = null;
                for (int ctr = 0; ctr <= 9; ctr++)
                    values[ctr] = ctr * 2;

                foreach (var value in values)
                    Console.WriteLine(value);
            }
			catch (NullReferenceException ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Финалочка");
			}
			try
			{
				Console.WriteLine("Введите значение a");
				int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение b");
                int b = Convert.ToInt32(Console.ReadLine());
				if (a != b)
				{
					throw new Exception();
				}
				else
				{
					Console.WriteLine("Числа равны");
				}
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
	}
}