using Microsoft.Data.SqlClient;
using System.Data;
using Лаб26Console;

string connectionString = "Server=AUDIT204_1\\SQLEXPRESS;Database=Buses;Trusted_Connection=True;TrustServerCertificate=True;";

// Создание подключения
SqlConnection connection = new SqlConnection(connectionString);
SqlCommand command = new SqlCommand();

try
{
    await connection.OpenAsync();
    command.Connection = connection;

    var cli = new AdoCli(connection, command);
    cli.Insert();
    cli.Update();
    cli.Delete();

}
catch (SqlException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    // если подключение открыто
    if (connection.State == ConnectionState.Open)
    {
        // закрываем подключение
        connection.Close();
        Console.WriteLine("Подключение закрыто...");
    }
}

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    Bus bus1 = new Bus { Number = 11, VodilaName = "Phil", Seats = 52 };
    Bus bus2 = new Bus { Number = 8, VodilaName = "Nikita", Seats = 52 };
    // добавляем их в бд
    //db.Buses.Add(bus1);
    //db.Buses.Add(bus2);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    var buses = (from bus in db.Buses
                 where bus.Number == 14
                 orderby bus.Seats
                 select bus).ToList();

    foreach (Bus u in buses)
    {
        Console.WriteLine($"{u.Id} {u.VodilaName} {u.Number} - {u.Seats}");
    }

    // получаем объекты из бд и выводим на консоль
    buses = db.Buses.ToList();
    Console.WriteLine("Список объектов:");
    foreach (Bus u in buses)
    {
        Console.WriteLine($"{u.Id} {u.VodilaName} {u.Number} - {u.Seats}");
    }


}
Console.WriteLine("Программа завершила работу.");
Console.Read();