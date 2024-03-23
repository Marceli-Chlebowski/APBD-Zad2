using ConsoleApp1.exceptios;
using ConsoleApp1.interfaces;

namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    public string Name;
    public readonly int Count = 1;
    public Boolean isDangerous;
    
//funkcja namest
    public string Nameset(char containertype)
    {
        string name = "KON-";
        string type = Convert.ToString(containertype);
        name += type;
        name += "-";
        name += Count;
        return name;
    } 
//constructor
    public LiquidContainer(double cargoweight, double height, double weight, double deep, double maxCargo, Boolean isDangerous) : base(cargoweight, height, weight, deep, maxCargo)
    {
        this.isDangerous = isDangerous;
        Name = Nameset(containertype: 'L');
        Count++;
    }
    
//danger function IHazardNotifier interface
    public void Danger()
    {
        Console.WriteLine("Dangerous event allert " + Name);
    }
    
//load liquid containers
    public override void Load(double cargoweight)
    {
        if (!isDangerous)
        {
            if (cargoweight + Cargoweight > MaxCargo * 0.9)
            {
                Danger();
                throw new OverfillException();
            }
        }
        else
        {
            if (cargoweight + Cargoweight > MaxCargo * 0.5)
            {
                Console.WriteLine("Dangerous cargo detected max load is half of the contaioner cappacity");
                Danger();
                throw new OverfillException();
            }
        }

        Cargoweight += cargoweight;
        Console.WriteLine("Current cargo weigt is " + Cargoweight);
    }
}