namespace CypherEngine.Models;

public class Focus
{
    public string name { get; set; } // The name of the focus
    public string description { get; set; } // The provided description
    public string? note { get; set; } // Notes found in the margins
    public List<string> connections { get; set; } // Focus Connections if present
    public List<AbilityRef> abilities { get; set; } // Abilities at each tier
    public string? intrusions { get; set; } // GM Intrusion suggestion
    public string? additional_equipment { get; set; } // Additional Equipment
    public string? minor_effect { get; set; } // Minor Effect Suggestion
    public string? major_effect { get; set; } // Major Effect Suggestion
}