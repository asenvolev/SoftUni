using System;
using System.Data.SqlClient;

namespace MinionNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=MinionsDB;Integrated Security=true");
            int villainId = int.Parse(Console.ReadLine());
            connection.Open();
            using (connection)
            {
                                
                string villainDbQuery = "SELECT Name FROM Villains WHERE Id = @villainId";

                var villainCommand = new SqlCommand(villainDbQuery, connection);

                villainCommand.Parameters.AddWithValue("@villainId", villainId);

                var reader = villainCommand.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Villain: {reader[0]}");
                }
                reader.Close();

                string minionsQuery = "SELECT [Name], Age FROM Minions AS m" +
                                      "JOIN MinionsVillains AS mv ON m.Id = mv.MinionId" +
                                      "WHERE mv.VillainId = @villianId";
                var minionsCommand = new SqlCommand(minionsQuery, connection);

                minionsCommand.Parameters.AddWithValue("@villianId", villainId);

                var minionreader = minionsCommand.ExecuteReader();

                int counter = 1;

                while (minionreader.Read())
                {
                    Console.WriteLine($"{counter} {reader[0]} {reader[1]}");
                    counter++;
                }
                minionreader.Close();
            }
        }
    }
}
