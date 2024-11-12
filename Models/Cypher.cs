namespace CypherEngine.Models;

public class Cypher
{
    public string name { get; set; } // The name of the cypher
    public string? form { get; set; } // The form of the cypher, if applicable
    public string? level_dice { get; set; } // The dice used to determine the level
    public uint level_mod { get; set; } // The additional modification to the level
    public string effect { get; set; } // The effect of the cypher
    public List<RollTable> options { get; set; } // A random roll table if applicable
    public List<string> kinds { get; set; } // MANIFEST, SUBTLE, FANTASTIC
}