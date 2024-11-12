namespace CypherEngine.Models;

public class Artifact
{
    public string name { get; set; } // Name of the Artifact
    public string? level_dice { get; set; } // Dice used to determine level
    public uint level_mod { get; set; } // Additional modifications to the level
    public string form { get; set; } // The form of the artifact
    public string depletion { get; set; } // The depletion range
    public string effect { get; set; } // The description
    public List<RollTable> options { get; set; } // A random roll table if applicable
}