namespace Polymorphism;

internal class Bird
{
    /// <summary>
    /// Purpose: Displays generic bird sound.
    /// Return Type: void
    /// </summary>
    public void Voice()
    {
        Console.WriteLine("Turr Turr");
    }
}

internal class Duck: Bird
{
    /// <summary>
    /// Purpose: Displays duck sound.
    /// Return Type: void
    /// </summary>
    // Method hiding.
    public new void Voice()
    {
        Console.WriteLine("Quack Quack");
    }
}
