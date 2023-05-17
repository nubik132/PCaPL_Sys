Task<double> task = new(() => Sqr(double.Parse(Console.ReadLine())));

task.Start();
double y = task.Result;
Console.WriteLine(y);

double Sqr(double x) => x * x;