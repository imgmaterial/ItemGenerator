using System.Diagnostics;

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

    public string ProduceItemStrings()
    {
        string output = string.Empty;
        foreach (Item item in Items)
        {
            output += item.ProduceItemString();
        }
        Console.WriteLine(output);
        output = $"{{\n {output}}}";
        Console.WriteLine(output);
        return output;
    }
}