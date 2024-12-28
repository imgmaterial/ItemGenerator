namespace TestBlazor.Services;

public class ItemManager
{
    public List<Item> Items { get; set; }
    public List<string> ItemAttributes { get; set; }
    public List<string> ItemTypes { get; set; }

    public ItemManager()
    {
        Items = new List<Item>();
        ItemAttributes =
        [
            "Health", "Mana", "Attack Damage", "Armor", "Strength", "Agility", "Intellect", "HP Regen", "MP Regen" ,
            "Spell Damage Amplification",
            "Attack Range", "Cooldown Reduction"
        ];
        ItemTypes = ["Head", "Chest", "Weapon", "Accessory", "Boots", "Consumable", "Miscellaneous"];
    }
}