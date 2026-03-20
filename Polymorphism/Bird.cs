namespace Polymorphism;

internal class Bird
{
    public void Voice()
    {
        Console.WriteLine("Turr Turr");
    }
}

internal class Duck: Bird
{
    public void Voice()
    {
        Console.WriteLine("Quack Quack");
    }
}
