using ConsoleApp1.exceptios;
namespace ConsoleApp1;

public class CoolingContainer : Container
{
    public string Name;
    public readonly int Count = 1;
    public string ProductType { get; set; }
    public double Temperature { get; set; }


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
    
    
    public CoolingContainer(double cargoweight, double height, double weight, double deep, double maxCargo,string productType, double temperature) : base(cargoweight, height, weight, deep, maxCargo)
    {
        ProductType = productType;
        Temperature = temperature;
        Name = Nameset(containertype: 'C');
        Count++;
        temperatureCheck();
       
    }

    public void typeCheck(string CargoType)
    {
        if (ProductType != CargoType)
        {
            throw new ProductTypeException();
        }
    } 
    
    public void temperatureCheck()
    {
        if (ProductType == "bananas" && Temperature < 13.3)
        {
            throw new TemperatureException();
        } 
        if (ProductType == "chocolate" && Temperature < 18)
        {
            throw new TemperatureException();
        } 
        if (ProductType == "fish" && Temperature < 2)
        {
            throw new TemperatureException();
        } 
        if (ProductType == "meat" && Temperature < -15)
        {
            throw new TemperatureException();
        }
        if (ProductType == "ice cream" && Temperature < -18)
        {
            throw new TemperatureException();
        } 
        if (ProductType == "frozen pizza" && Temperature < -30)
        {
            throw new TemperatureException();
        }
        if (ProductType == "cheese" && Temperature < 7.2)
        {
            throw new TemperatureException();
        }
        if (ProductType == "sausages" && Temperature < 5)
        {
            throw new TemperatureException();
        }
        if (ProductType == "butter" && Temperature < 20.5)
        {
            throw new TemperatureException();
        }
        if (ProductType == "eggs" && Temperature < 19)
        {
            throw new TemperatureException();
        }
    }
    //funkcje przeladunkowa 
    public new void Unload()
    {
        Cargoweight = 0;
        Console.WriteLine("Current cargo weigt is " + Cargoweight);
    }
    
    public virtual void Load(double cargoweight, string CargoType)
    {
        if (cargoweight + Cargoweight > MaxCargo)
        {
            throw new OverfillException();
        }
        typeCheck(CargoType);
        Cargoweight += cargoweight;
        Console.WriteLine("Current cargo weigt is " + Cargoweight);
    }
}