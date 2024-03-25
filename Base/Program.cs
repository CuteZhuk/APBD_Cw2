namespace APBD_Cw2.Base;

class Program
{
    static void Main(string[] args)
    {
        Container container = new Container("A", 5000, 1000, 200, 150);
        
        ContainerShip ship = new ContainerShip("Ocean Voyager", 20, 200, 50000);
        LiquidContainer liquidContainer = new LiquidContainer("KON-L-C-1", 5000, 1000, 200, 150);
        ship.LoadContainer(liquidContainer);

    }
}