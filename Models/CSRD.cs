namespace CypherEngine.Models;

public class CSRD
{
    public DateTime version { get; set; } // The date the json was generated
    public List<Type> types { get; set; } // A list of types
    public List<Flavor> flavors { get; set; } // A list of flavors
    public List<Descriptor> descriptors { get; set; } // A list of descriptors
    public List<Focus> foci { get; set; } // A list of foci
    public List<Ability> abilities { get; set; } // A list of abilities
    public List<Cypher> cyphers { get; set; } // A list of cyphers
    public List<RollTable> cypher_tables { get; set; } // A list of roll tables for cyphers
    public List<RollTable> intrusion_tables { get; set; } // A list of intrusion tables
    public List<RollTable> other_tables { get; set; } // A list of misc tables
    public List<Artifact> artifacts { get; set; } // A list of artifacts
    public List<Creature> creatures { get; set; } // A list of creatures and npcs
    public List<Equipment> equipment { get; set; } // A list of equipment
}