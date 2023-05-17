string path = @"E:\test";
string subpath = @"folder1";
string subpath1 = @"folder2";
DirectoryInfo dirInfo = new DirectoryInfo(path);
if (!dirInfo.Exists)
{
    dirInfo.Create();
}
dirInfo.CreateSubdirectory(subpath);
dirInfo.CreateSubdirectory(subpath1);


Console.WriteLine("Введите символ: y - перенести папку, n - не перемещать");
string Symb = Console.ReadLine();
if (Symb == "y")
{
    string oldPath = @"E:\test\folder1";
    string newPath = @"E:\test\folder2\folder1";
    DirectoryInfo dirInfo1 = new DirectoryInfo(oldPath);
    if (dirInfo.Exists && !Directory.Exists(newPath))
    {
        dirInfo1.MoveTo(newPath);
        Console.WriteLine("папка перемещена");
    }
}
else if (Symb == "n")
{
    Console.WriteLine("папка не перемещена");
}
else
{
    Console.WriteLine("Некоректный символ");
}

Console.WriteLine("Введите символ: y - удалить папку folder1, n - не удалять");
string Symb1 = Console.ReadLine();
if (Symb1 == "y")
{
    string dirName = @"E:\test\folder1";
    string dirName1 = @"E:\test\folder2\folder1";
    if (Directory.Exists(dirName))
    {
        Directory.Delete(dirName, true);
        Console.WriteLine("Каталог удален");
    }
    else if (Directory.Exists(dirName1))
    {
        Directory.Delete(dirName1, true);
        Console.WriteLine("Каталог удален");
    } 
    else
    {
        Console.WriteLine("Каталог не существует");
    }
}

else if (Symb1 == "n")
{
    Console.WriteLine("папка не удалена");
}
else
{
    Console.WriteLine("Некоректный символ");
}

StreamWriter file = new StreamWriter(@"E:\test\test.txt", true);
string a = "Строка";
int b = 45;
double c = 67.4;
double f = 91.1;
double g = 15.2;
file.Write(a + " " + b + " " + c + " " +  f + " ");
file.Close();
file = new StreamWriter(@"E:\test\test.txt", true);
file.Write(g);
file.Close();


StreamReader file1 = new StreamReader(@"E:\test\test.txt");
string stroka = file1.ReadToEnd();
string[] rstroka = stroka.Split();
string a2 = rstroka[0];
int b2 = Convert.ToInt32(rstroka[1]);
double c2 = Convert.ToDouble(rstroka[2]);
double f2 = Convert.ToDouble(rstroka[3]);
double g2 = Convert.ToDouble(rstroka[4]);
Console.WriteLine(a2 + " " + b2 + " " + c2 + " " + f2 + " " + g2);
file1.Close();
//file = new StreamWriter(@"E:\test\test.txt");
//file.WriteLine();