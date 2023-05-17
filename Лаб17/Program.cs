using System.Text.Json;
using System.Text.Json.Serialization;

Service? service = new() { Price = 78,
    Name = "Развлекательная программа \"Мишк Фреде и другие\"",
    Description = @"Тут вас встретят:
Мишк фреде
Кролик Боние
Все на чиле, раслабони
Цыпа Чика"};

service.Print();
File.WriteAllText("service.json",
    JsonSerializer.Serialize(service, 
    new JsonSerializerOptions() {WriteIndented = true }));

service = JsonSerializer.Deserialize<Service>(
        File.ReadAllText("service.json"));
service.Print();


[Serializable]
class Service
{
    public int Price { get; set; }
    [JsonPropertyName("ThisName")]
    public string Name { get; set; }
    [JsonIgnore]
    public string Description { get; set; }
    public void Print()
    {
        Console.WriteLine($"{Name}\nЦена: {Price}\n{Description}\n");
    }
}