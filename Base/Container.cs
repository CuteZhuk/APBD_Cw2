namespace APBD_Cw2.Base;

public class Container
{
    public string SerialNumber { get; }
    public double CargoWeight { get; private set; }
    public double Height { get; }
    public double OwnWeight { get; }
    public double Depth { get; }
    public double MaxLoad { get; }

    public Container(string serialNumber, double maxLoad, double ownWeight, double height, double depth)
    {
        SerialNumber = serialNumber;
        MaxLoad = maxLoad;
        OwnWeight = ownWeight;
        Height = height;
        Depth = depth;
    }

    public void LoadCargo(double weight)
    {
        if (CargoWeight + weight <= MaxLoad)
        {
            CargoWeight += weight;
            Console.WriteLine($"Cargo loaded: {weight} kg");
        }
        else
        {
            Console.WriteLine("Cargo exceeds maximum load capacity.");
        }
    }

    public void UnloadCargo()
    {
        CargoWeight = 0;
        Console.WriteLine("Cargo unloaded.");
    }
}