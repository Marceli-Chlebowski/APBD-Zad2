using ConsoleApp1.exceptios;
using ConsoleApp1.interfaces;
namespace ConsoleApp1.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Preassure { get; set; }
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
        Preassure = preassure;
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
        Console.WriteLine("Current cargo weigt is " + Cargoweight);
    }
    public virtual void Load(double cargoweight)
    {
        if (cargoweight + Cargoweight > MaxCargo)
        {
            Danger();
            throw new OverfillException();
        }
        Cargoweight += cargoweight;
        Console.WriteLine("Current cargo weigt is " + Cargoweight);
    }
    public void ShowContainerInfo()
    {
        Console.WriteLine(
            "Name: " + Name +
            "\n" +
            "Cargo Weight: " + Cargoweight  + 
            "\n" +
            "Height: " + Height + 
            "\n" +
            "Total Weight: " + (Weight+Cargoweight) +
            "\n" +
            "Depth: " + Deep + 
            "\n" +
            "Cargo Weight Maximum: " + MaxCargo +
            "\n" +
            "Pressure : " + Preassure
        );
    }
    
}



