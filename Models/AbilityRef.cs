namespace CypherEngine.Models;

public class AbilityRef
{
    public string name { get; set; } // The name of the ability
    public uint tier { get; set; } // What tier the ability is unlocked
    public bool preselected { get; set; } // Whether the ability was preselected or optional
}