using ConsoleApp1.interfaces;

namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    public string Name;
    public readonly int Count = 0;
    
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
    public LiquidContainer(double cargoweight, double height, double weight, double deep, char containertype, double maxCargo) : base(cargoweight, height, weight, deep, containertype, maxCargo)
    {
        Name = Nameset(containertype: 'L');
        Count++;
    }
    
//danger function IHazardNotifier interface
    public void Danger(string name)
    {
        Console.WriteLine("Dangerous event allert" + Name);
        
    }
}