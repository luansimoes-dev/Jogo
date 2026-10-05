using RPG.Entities;

namespace RPG.Data;

public enum ItemType
{
    Consumable,
    Weapon,
    Armor,
    Key
}

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ItemType Type { get; set; }
    public int Value { get; set; }

    public Item(string name, string description, ItemType type, int value = 0)
    {
        Name = name;
        Description = description;
        Type = type;
        Value = value;
    }

    public virtual void Use(Player player)
    {
    }
}
