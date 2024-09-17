namespace habit_tracker;
class Program
{
    static void Main(string[] args)
    {
        var databaseManager = new DatabaseManager();
        databaseManager.InitializeDatabase();
    }  
}

