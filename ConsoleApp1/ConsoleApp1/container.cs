using ConsoleApp1.exceptios;
using ConsoleApp1.interfaces;

namespace ConsoleApp1;

public class Container : IContainer
{
//zmienne
    public double Cargoweight { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Deep { get; set; }
    public double MaxCargo { get; set; }

    public Container(double cargoweight, double height, double weight, double deep, double maxCargo)
    {
        Cargoweight = cargoweight;
        Height = height;
        Weight = weight;
        Deep = deep;
        MaxCargo = maxCargo;
    }

//funkcje przeladunkowa 
    public void Unload()
    {
        if (Cargoweight == 0)
            throw new NotImplementedException();

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
}