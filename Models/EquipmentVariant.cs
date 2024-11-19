namespace CypherEngine.Models;

public class EquipmentVariant
{
    public string description { get; set; } = ""; // The description, potentially unique to the setting
    public HashSet<string> notes { get; set; } = []; // Notes found in tables, such as "Medium Weapon" or "Short range"
    public HashSet<string> tags { get; set; } = []; // Settings and headers, such as "FANTASY" and "APPAREL & ARMOR"
    public List<string> value { get; set; } = []; // How much the item is worth, such as "expensive" or "50 gp"
    public List<uint> levels { get; set; } = []; // The level of the gear if described.
}