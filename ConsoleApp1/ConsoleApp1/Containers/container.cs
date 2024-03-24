using ConsoleApp1.exceptios;
using ConsoleApp1.interfaces;
namespace ConsoleApp1.Containers;

public class Container : IContainer
{
//zmienne
    public double Cargoweight { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Deep { get; set; }
    public double MaxCargo { get; set; }
    public string Name;
    private static int Count = 1;

    public Container(double cargoweight, double height, double weight, double deep, double maxCargo)
    {
        Cargoweight = cargoweight;
        Height = height;
        Weight = weight;
        Deep = deep;
        MaxCargo = maxCargo;
        Name = Nameset(containertype: 'B', Count);
        Count++;
    }
    
    //funkcja namest
    public string Nameset(char containertype, int count)
    {
        string name = "KON-";
        string type = Convert.ToString(containertype);
        name += type;
        name += "-";
        name += Convert.ToString(count);
        return name;
    } 

//funkcje przeladunkowa 
    public void Unload()
    {
        if (Cargoweight == 0)
            Console.WriteLine("Cargo is empty");

        Cargoweight = 0;
        Console.WriteLine("Current cargo weigt is " + Cargoweight);
    }

    public virtual void Load(double cargoweight)
    {
        if (cargoweight + Cargoweight > MaxCargo)
        {
            throw new OverfillException();
        }
        Cargoweight += cargoweight;
        Console.WriteLine("Current cargo weigt is " + Cargoweight);
    }

    public void ShowContainerInfo()
    {
        Console.WriteLine(
            "Cargo Weight: " + Cargoweight  + 
            "\n" +
            "Height: " + Height + 
            "\n" +
            "Total Weight: " + (Weight+Cargoweight) +
            "\n" +
            "Depth: " + Deep + 
            "\n" +
            "Cargo Weight Maximum: " + MaxCargo
            );
    }

    public override string ToString()
    {
        return Name;
    }
}