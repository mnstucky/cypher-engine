namespace CypherEngine.Models;

public class Type
{
    public string name { get; set; } = ""; // The name of the Type
    public List<BasicAbility> intrusions { get; set; } = []; // Intrusion suggestions
    public Dictionary<string, uint> stat_pool { get; set; } = []; // Starting stat_pool
    public RollTable background { get; set; } = new(); // Background suggestions
    public List<Amount> special_abilities_per_tier { get; set; } = []; // Special Abilities unlocked at each tier
    public List<BasicAbility> abilities { get; set; } = []; // Basic abilities like Starting Equipment and Effort
    public List<AbilityRef> special_abilities { get; set; } = []; // Abilities found at each tier
}