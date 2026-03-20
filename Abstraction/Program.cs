using Abstraction;

namespace Polymorphism;

internal class Program
{
    static void Main()
    {
        Laptop laptop = new Laptop();

        laptop.Brand = "Dell";
        laptop.Model = "XPS 15";

        laptop.LaptopDetails();

        laptop.MotherBoardInfo();
    }
}