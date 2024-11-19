namespace CypherEngine.Models;

public class Flavor
{
    public string name { get; set; } = ""; // The name of the Flavor
    public string description { get; set; } = ""; // The description provided for the flavor
    public List<AbilityRef> abilities { get; set; } = []; // Abilities found at each tier
}