namespace APBD_Cw2.Base;

public class Program
{
    static void Main(string[] args)
    {
        ContainerShip ship = new ContainerShip("Ocean Voyager", 20, 200, 50000);
        LiquidContainer liquidContainer = new LiquidContainer("KON-L-C-1", 5000, 1000, 200, 150);
        GasContainer gasContainer = new GasContainer("KON-G-C-1", 6000, 1200, 210, 160);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer("KON-C-C-1", 7000, 1500, 220, 170, "Bananas", 13.3);

        ship.LoadContainer(liquidContainer);
        ship.LoadContainer(gasContainer);
        ship.LoadContainer(refrigeratedContainer);
        
        liquidContainer.LoadCargo(20);
        gasContainer.LoadCargo(10);

        ship.PrintShipInfo();
    }
}