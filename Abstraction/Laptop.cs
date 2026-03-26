namespace Abstraction;

internal class Laptop
{

    private string? brand;
    private string? model;

    public string Brand
    {
        get => brand ?? throw new InvalidOperationException("Brand must be assigned a non-null value.");
        set { brand = value; }
    }

    public string Model
    {
        get => model ?? throw new InvalidOperationException("Model must be assigned a non-null value.");
        set { model = value; }
    }

    /// <summary>
    /// Purpose: Displays laptop's brand and model details.
    /// Return Type: void
    /// </summary>
    public void LaptopDetails()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
    }

    /// <summary>
    /// Purpose: Displays motherboard information of the laptop. This is a private method.
    /// Return Type: void
    /// </summary>
    private void MotherBoardInfo()
    {
        Console.WriteLine("MotherBoard Information");
    }
}
