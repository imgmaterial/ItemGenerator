namespace TestBlazor.Services;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public List<ItemAttribute> Attributes { get; set; }
    
    public string ItemType { get; set; }
    
    public string UniqueEffect { get; set; }

    public Item(string name,string itemType, string description, string imageUrl, string uniqueEffect, List<ItemAttribute> attributes)
    {
        this.Name = name;
        this.ItemType = itemType;
        this.Description = description;
        this.ImageUrl = imageUrl;
        this.Attributes = attributes;
        this.UniqueEffect = uniqueEffect;
    }

    public string ProduceItemString()
    {
        string attributeString = "[\n";
        foreach (ItemAttribute attribute in Attributes)
        {
            attributeString += $"\t{attribute.Name}:{attribute.Value}\n";
        }

        attributeString += "]";
        string output = $"{{\n Name:{this.Name}\n ItemType:{this.ItemType}\n Description:{this.Description}\n Attributes:{attributeString}\n UniqueEffect:{this.UniqueEffect}}}\n";
        return output;
    }
}