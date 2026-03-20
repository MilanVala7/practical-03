namespace Abstraction;

internal class Laptop
{
    private string brand;
    private string model;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    /// <summary>
    /// Purpose: Displays laptop brand and model details.
    /// Return Type: void
    /// </summary>
    public void LaptopDetails()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
    }

    /// <summary>
    /// Purpose: Displays motherboard information of the laptop.
    /// Return Type: void
    /// </summary>
    private void MotherBoardInfo()
    {
        Console.WriteLine("MotherBoard Information");
    }
}
