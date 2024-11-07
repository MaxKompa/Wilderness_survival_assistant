namespace Wilderness_survival_assistant.equipment;

public class EquipmentItem
{
    public string Name { get; set; }
    public bool IsCollected { get; set; }

    public EquipmentItem(string name)
    {
        Name = name;
        IsCollected = false;
    }

    public override string ToString()
    {
        return $"{Name} - {(IsCollected ? "Collected" : "Not collected")}";
    }
}