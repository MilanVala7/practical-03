using Abstraction;

namespace Polymorphism;

internal class Program
{
    static void Main()
    {
        Laptop laptop = new Laptop();

        laptop.Brand = "Dell";
        laptop.Model = "XPS 15";

        // displays the laptop details.
        laptop.LaptopDetails();

        /// This method can not be called here because it is a private method
        /// It shows error: inaccessible due to its protection level
        // laptop.MotherBoardInfo();
    }
}