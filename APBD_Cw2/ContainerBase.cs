namespace APBD_Cw2;

public class ContainerBase
{
    protected double MaxWeight
    {
        get;
    }

    protected double Weight
    {
        get;
        set;
    }

    protected ContainerBase(double maxWeight)
    {
        MaxWeight = maxWeight;
    }
}