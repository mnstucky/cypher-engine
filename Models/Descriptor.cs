namespace CypherEngine.Models;

public class Descriptor
{
    public string name { get; set; } = ""; // The name of the Descriptor
    public string description { get; set; } = ""; // The provided description
    public List<BasicAbility> characteristics { get; set; } = []; // Basic abilities such as skills and pool points
    public List<string> links { get; set; } = []; // Starting Adventure Links
}
