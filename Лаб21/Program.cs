Thread thread = new(sourceTypes =>
{
    if (sourceTypes is Types types)
    {
        Console.WriteLine($"{types.doubleParam}\n" +
            $"{(float)types.floatParam}\n" +
            $"{(int)types.intParam}\n" +
            $"{(char)types.charParam}\n");
    }
});

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Black;

var types = new Types();
thread.Start(types);



class Types
{
    public double doubleParam;
    public double floatParam;
    public double intParam;
    public double charParam;

    public Types()
    {
        Random random = new Random();
        doubleParam = random.NextDouble();
        floatParam = random.NextDouble();
        intParam = random.Next();
        charParam = (random.Next() % 255);
    }
}