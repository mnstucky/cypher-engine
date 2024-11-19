using CypherEngine.Models;
using System.IO;
using System.Text.Json;

namespace CypherEngine.Services;

public static class DataService
{
    public static CSRD Database { get; set; } = new();

    public static async Task<bool> SetupDatabase()
    {
        try
        {
            var jsonString = await File.ReadAllTextAsync("CSRD.json");
            var maybeDatabase = JsonSerializer.Deserialize<CSRD>(jsonString);
            if (maybeDatabase is null)
            {
                return false;
            }
            Database = maybeDatabase;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }
        return true;
    }
}