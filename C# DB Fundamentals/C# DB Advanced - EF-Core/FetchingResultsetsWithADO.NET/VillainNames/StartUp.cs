using System;
using System.Data.SqlClient;
using System.Text;
namespace VillainNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            var connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=MinionsDB;Integrated Security=true");
            connection.Open();
            using (connection)
            {
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("SELECT v.Name, COUNT(mv.MinionID) FROM Villains AS v");
                    sb.AppendLine("JOIN MinionsVillains AS mv ON v.Id = mv.VillainId");
                    sb.AppendLine("GROUP BY v.Name");
                    sb.AppendLine("HAVING COUNT(mv.MinionID) > 3");
                    sb.AppendLine("ORDER BY COUNT(mv.MinionID) DESC");
                    string createDbQuery = sb.ToString();
                    var sql = new SqlCommand(createDbQuery, connection);
                    var reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
