namespace APBD_Cw2.Base;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(string serialNumber, double maxLoad, double ownWeight, double height, double depth) 
        : base(serialNumber, maxLoad, ownWeight, height, depth)
    {
    }

    public void NotifyDanger(string containerSerialNumber)
    {
        Console.WriteLine($"Dangerous situation detected in liquid container: {containerSerialNumber}");
    }

    public void LoadCargo(double weight)
    {
        if (weight <= MaxLoad * 0.5)
        {
            base.LoadCargo(weight);
        }
        else
        {
            Console.WriteLine("Attempted to load hazardous cargo beyond permitted capacity.");
        }
    }
}