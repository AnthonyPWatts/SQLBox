namespace SqlBox.Core;

public static class DatabaseBuilder
{
    public static void Build(string sqlDir)
    {
        if (!Directory.Exists(sqlDir))
        {
            Console.WriteLine($"Directory not found: {sqlDir}");
            return;
        }

        var sqlFiles = Directory.GetFiles(sqlDir, "*.sql")
                                .OrderBy(f => f)  // Ensures 001.sql -> 002.sql order
                                .ToList();

        Console.WriteLine($"Found {sqlFiles.Count} SQL files.");

        // Placeholder for executing SQL
    }
}
