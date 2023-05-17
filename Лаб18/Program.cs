#region 1
using System.Collections;

List<string> fingers = new List<string> { "большой", "указательный", "средний" };

fingers.Add("безымянный");
fingers.Add("мизинец");

fingers.RemoveAll(a => a.Length > 7);

fingers.Insert(0, "мизинец");
foreach (var item in fingers)
{
    Console.WriteLine(item);
}
Console.WriteLine();
#endregion

#region 2
ArrayList arrayList= new ArrayList { true, false, 1, 7.6, "Амфибия" };

Console.WriteLine("arrayList содержит 2: " + (arrayList.Contains(2)? "Да": "Нет"));
Console.WriteLine();
#endregion

#region 3
Dictionary<string, double> songs = new()
{
    { "Bad To The Bone", 5.41 },
    { "Where Is My Mind?", 3.5 },
    { "Monster", 3.01 },
    { "The Kids Aren't Alright", 3.01 }
};

Console.WriteLine("песня длительностью 3.5 минуты " + (songs.ContainsValue(3.5) ? "cуществует" : "не cуществует"));
#endregion