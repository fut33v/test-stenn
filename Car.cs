public class Car
{
    public Car(string model, string color, string description) {
        Model = model;
        Color = color;
        Description = description;
    }

    public string Model { get; set; }
    public string Color {get; set; }
    public string Description  {get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null) {
            return false;
        }
        return Equals(obj as Car);
    }

    public bool Equals(Car? other)
    {
        return other != null &&
               Model == other.Model &&
               Color == other.Color;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Model, Color);
    }
}