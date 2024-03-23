using ConsoleApp1.exceptios;

namespace ConsoleApp1.interfaces;

public class GasContainer : Container, IHazardNotifier
{
    public double preassure;
    public string Name;
    public readonly int Count = 1;
    
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
    
    public GasContainer(double cargoweight, double height, double weight, double deep, double maxCargo, double preassure) : base(cargoweight, height, weight, deep, maxCargo)
    {
        this.preassure = preassure;
        Name = Nameset(containertype: 'G');
        Count++;
    }

    public void Danger()
    {
        Console.WriteLine("Dangerous event allert " + Name);
    }
    
    //funkcje przeladunkowa 
    public new void Unload()
    {
        Cargoweight = Cargoweight * 0.05;
    }

    public override void Load(double cargoweight)
    {
        if (cargoweight + Cargoweight > MaxCargo)
        {
            throw new OverfillException();
        }
        Cargoweight += cargoweight;
    }
}



