namespace Polymorphism;

internal class Program
{
    static void Main()
    {
        Bird myBird = new Bird();

        Duck myDuck = new Duck();

        myBird.Voice();

        myDuck.Voice();
    }
}