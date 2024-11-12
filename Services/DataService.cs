using CypherEngine.Models;
using System.IO;
using System.Text.Json;

namespace CypherEngine.Services;

public static class DataService
{
    public static CSRD Database { get; set; }

    public static async Task<bool> SetupDatabase()
    {
        try
        {
            var jsonString = await File.ReadAllTextAsync("../../../CSRD.json");
            Database = JsonSerializer.Deserialize<CSRD>(jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }
        return true;
    }
}