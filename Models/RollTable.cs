namespace CypherEngine.Models;

public class RollTable
{
    public string? name { get; set; } // The name of the current roll table if applicable
    public string? description { get; set; } // A potential description describing the roll table
    public List<RollEntry> table { get; set; } // Each roll entry in the table.
}