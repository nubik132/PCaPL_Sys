using System;

void BiggestOf(double a, double b, double c)
{
    double[] array = { a, b, c };
    Console.WriteLine(array.Max());
}

//---------------------------------------------------------

ThreeDouble treeDouble = BiggestOf;
treeDouble += delegate (double a, double b, double c)
{
    double[] array = { a, b, c };
    Console.WriteLine(array.Min());
};

treeDouble += (double a, double b, double c) =>
{
    double[] array = { a, b, c };
    Console.WriteLine(array.Sum());
};

treeDouble(Double.Parse(Console.ReadLine()),
            Double.Parse(Console.ReadLine()),
            Double.Parse(Console.ReadLine()));

//----------------------------------------------------------

delegate void ThreeDouble(double a, double b, double c);
