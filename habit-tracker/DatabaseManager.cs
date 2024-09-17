using Microsoft.Data.Sqlite;

namespace habit_tracker
{
    public class DatabaseManager
    {
        private const string connectionString = @"Data Source=habit-tracker.db";
        public void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS drinking_water (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Date TEXT,
            Quantity INTEGER
            )";

                tableCmd.ExecuteNonQuery();

                connection.Close();
            }
            HabitRepository.GetUserInput();
        }
    }
}