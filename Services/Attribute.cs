namespace TestBlazor.Services;

public class Attribute
{
    public string Name { get; set; }
    public float Value { get; set; }

    public Attribute(string name, float value)
    {
        this.Name = name;
        this.Value = value;
    }
}