namespace CypherEngine.Models;

public class Creature
{
    public string name { get; set; } = ""; // The name of the creature
    public string kind { get; set; } = ""; // Creature, NPC, or Super villain
    public uint? level { get; set; } // Level 1-10
    public string description { get; set; } = ""; // provided description
    public string? motive { get; set; } // provided motive
    public string? environment { get; set; } // environment if any
    public uint? health { get; set; } // health
    public string? damage { get; set; } // damage dealt,
    public uint armor { get; set; } // armor, 0 if none
    public string? movement { get; set; } // movement speed
    public List<string> modifications { get; set; } = []; // list of modifications
    public string? combat { get; set; } // combat options
    public string? interactions { get; set; } // interactions
    public string? uses { get; set; } // use if any
    public string? loot { get; set; } // loot if any
    public string? intrusions { get; set; } // GM intrusions if any
}