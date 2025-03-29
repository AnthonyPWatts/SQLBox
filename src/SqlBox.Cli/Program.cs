using SqlBox.Core;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: sqlbox <path-to-sql-directory>");
            return;
        }

        string sqlDir = args[0];
        Console.WriteLine($"Processing SQL files from: {sqlDir}");

        // Placeholder for actual logic
        DatabaseBuilder.Build(sqlDir);
    }
}
