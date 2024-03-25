namespace APBD_Cw2.Base;

class Program
{
    static void Main(string[] args)
    {
        Container container = new Container("A", 5000, 1000, 200, 150);

        Console.WriteLine($"Serial Number: {container.SerialNumber}");
        Console.WriteLine($"Type: {container.Type}");
        Console.WriteLine($"Max Load: {container.MaxLoad} kg");
        Console.WriteLine($"Empty Weight: {container.EmptyWeight} kg");
        Console.WriteLine($"Height: {container.Height} cm");
        Console.WriteLine($"Depth: {container.Depth} cm");

        container.Load(3000); // Load cargo
        Console.WriteLine($"Current Load: {container.LoadWeight} kg");

        container.Unload(); // Unload cargo
        Console.WriteLine($"Current Load: {container.LoadWeight} kg");
    }
}