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
}