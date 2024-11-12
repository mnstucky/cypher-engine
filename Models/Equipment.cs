namespace CypherEngine.Models;

public class Equipment
{
    public string name { get; set; } // The name of the equipment
    public List<EquipmentVariant> variants { get; set; } // The different variants mentioned in csrd
}