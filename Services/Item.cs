namespace TestBlazor.Services;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public List<Attribute> Attributes { get; set; }

    public Item(string name, string description, string imageUrl, List<Attribute> attributes)
    {
        this.Name = name;
        this.Description = description;
        this.ImageUrl = imageUrl;
        this.Attributes = attributes;
    }
}