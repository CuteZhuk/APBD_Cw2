namespace APBD_Cw2.Base;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; }
    public double Temperature { get; }

    public RefrigeratedContainer(string serialNumber, double maxLoad, double ownWeight, double height, double depth, string productType, double temperature)
        : base(serialNumber, maxLoad, ownWeight, height, depth)
    {
        ProductType = productType;
        Temperature = temperature;
    }
}