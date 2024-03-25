namespace APBD_Cw2.Base;

public class GasContainer : Container, IHazardNotifier
{
    private const double PRESSURE_THRESHOLD = 10; // Example pressure threshold

    public double Pressure { get; private set; }

    public GasContainer(string serialNumber, double maxLoad, double ownWeight, double height, double depth) 
        : base(serialNumber, maxLoad, ownWeight, height, depth)
    {
    }

    public void NotifyDanger(string containerSerialNumber)
    {
        Console.WriteLine($"Dangerous situation detected in gas container: {containerSerialNumber}");
    }

    public void LoadCargo(double weight)
    {
        if (weight <= MaxLoad)
        {
            base.LoadCargo(weight);
        }
        else
        {
            Console.WriteLine("Cargo weight exceeds maximum load capacity.");
        }
    }

    public void UnloadCargo()
    {
        base.UnloadCargo();
        Pressure = 0.05 * MaxLoad;
    }
}