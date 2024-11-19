namespace CypherEngine.Models;

public class Ability
{
    public string name { get; set; } = ""; // The name of the ability
    public int? cost { get; set; } // The minimum point cost, if any
    public List<string> pool { get; set; } = []; // The pools this ability can use
    public string? additional_cost { get; set; } // Other costs such as XP
    public string cost_rendered { get; set; } = ""; // The cost as displayed in the csrd
    public string? tier { get; set; } // General Tier: Low, Mid, High
    public List<string> category { get; set; } = []; // Categories found in Chapter 9
    public string description { get; set; } = ""; // Description of the ability
    public List<string> references { get; set; } = []; // Locations this ability pops up
}