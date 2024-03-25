namespace APBD_Cw2.Base;

public class ContainerShip
{
    public string Name { get; }
    public double MaxSpeed { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }
    public List<Container> Containers { get; }

    public ContainerShip(string name, double maxSpeed, int maxContainers, double maxWeight)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
        Containers = new List<Container>();
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count < MaxContainers && TotalWeight() + container.OwnWeight <= MaxWeight)
        {
            Containers.Add(container);
            Console.WriteLine($"Container {container.SerialNumber} loaded onto ship.");
        }
        else
        {
            Console.WriteLine("Unable to load container onto ship due to capacity constraints.");
        }
    }

    public void UnloadContainer(string containerSerialNumber)
    {
        Container container = Containers.Find(c => c.SerialNumber == containerSerialNumber);
        if (container != null)
        {
            Containers.Remove(container);
            Console.WriteLine($"Container {containerSerialNumber} unloaded from ship.");
        }
        else
        {
            Console.WriteLine($"Container {containerSerialNumber} not found on the ship.");
        }
    }

    public void ReplaceContainer(string oldSerialNumber, Container newContainer)
    {
        int index = Containers.FindIndex(c => c.SerialNumber == oldSerialNumber);
        if (index != -1)
        {
            Containers[index] = newContainer;
            Console.WriteLine($"Container {oldSerialNumber} replaced with {newContainer.SerialNumber}.");
        }
        else
        {
            Console.WriteLine($"Container {oldSerialNumber} not found on the ship.");
        }
    }

    public void PrintShipInfo()
    {
        Console.WriteLine($"Container Ship {Name}:");
        Console.WriteLine($"Maximum Speed: {MaxSpeed} knots");
        Console.WriteLine($"Maximum Containers: {MaxContainers}");
        Console.WriteLine($"Maximum Weight: {MaxWeight} tons");
        Console.WriteLine($"Total Containers: {Containers.Count}");
        double totalWeight = TotalWeight();
        Console.WriteLine($"Total Weight: {totalWeight} tons");
    }

    private double TotalWeight()
    {
        double total = 0;
        foreach (Container container in Containers)
        {
            total += container.OwnWeight + container.CargoWeight;
        }
        return total;
    }
}