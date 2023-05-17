using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб26Console
{
    internal class AdoCli
    {
        public SqlConnection connection;
        public SqlCommand command;

        public AdoCli(SqlConnection connection, SqlCommand command)
        {
            this.connection = connection;
            this.command = command;
        }

        public void Insert()
        {
            Console.WriteLine("Введите Number, VodilaName, Seats в строку");
            var pars = Console.ReadLine().Split();
            command.CommandText = $"INSERT INTO Buses (number, vodilaname, seats) VALUES({pars[0]}, '{pars[1]}', {pars[2]});";
            command.ExecuteNonQuery();
        }

        public void Delete()
        {
            Console.WriteLine("Введите номер автобуса, который хотите удалить");
            var number = Console.ReadLine();
            command.CommandText = $"DELETE FROM Buses WHERE number = {number};";
            command.ExecuteNonQuery();
        }

        public void Update()
        {
            Console.WriteLine("Введите номер автобуса, данные которого хотите изменить");
            var number = Console.ReadLine();
            Console.WriteLine("Введите Number, VodilaName, Seats в строку");
            var pars = Console.ReadLine().Split();
            command.CommandText = $"UPDATE Buses SET number = {pars[0]}, vodilaname = '{pars[1]}', seats = {pars[2]} WHERE number = {number}";
            command.ExecuteNonQuery();
        }
    }
}
