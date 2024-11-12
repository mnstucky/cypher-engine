namespace CypherEngine.Models;

public class RollEntry
{
    public uint start { get; set; } // starting range inclusive
    public uint end { get; set; } // ending range inclusive
    public string entry { get; set; } // name/description
}