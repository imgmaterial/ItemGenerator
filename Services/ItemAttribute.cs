namespace TestBlazor.Services;

public class ItemAttribute
{
    public string Name { get; set; }
    public float Value { get; set; }

    public ItemAttribute(string name, float value)
    {
        this.Name = name;
        this.Value = value;
    }
}