namespace APBD_Cw2.Base;

public class Container
{
    public string SerialNumber { get; }
    public string Type { get; }
    public double MaxLoad { get; }
    public double EmptyWeight { get; }
    public double LoadWeight { get; private set; }
    public double Height { get; }
    public double Depth { get; }

    public Container(string type, double maxLoad, double emptyWeight, double height, double depth)
    {
        SerialNumber = GenerateSerialNumber(type);
        Type = type;
        MaxLoad = maxLoad;
        EmptyWeight = emptyWeight;
        LoadWeight = 0;
        Height = height;
        Depth = depth;
    }

    private string GenerateSerialNumber(string type)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 1000);
        return $"KON-{type}-C-{randomNumber}";
    }

    public void Load(double cargoWeight)
    {
        if (LoadWeight + cargoWeight <= MaxLoad)
        {
            LoadWeight += cargoWeight;
            Console.WriteLine($"Cargo loaded: {cargoWeight} kg");
        }
        else
        {
            Console.WriteLine("Cargo exceeds maximum load capacity.");
        }
    }

    public void Unload()
    {
        LoadWeight = 0;
        Console.WriteLine("Cargo unloaded.");
    }
}