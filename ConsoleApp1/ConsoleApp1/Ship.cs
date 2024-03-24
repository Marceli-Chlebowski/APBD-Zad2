using ConsoleApp1.Containers;

namespace ConsoleApp1;

public class Ship
{
    public double Speed;
    public double maxContainerCount;
    public double maxLoad;
    private List<Container> containersList = new List<Container>();
    public String Name;
    
    public Ship(double speed, double maxContainerCount, double maxLoad, string name)
    {
        Speed = speed;
        this.maxContainerCount = maxContainerCount;
        this.maxLoad = maxLoad;
        Name = name;
    }

    public void loadContaier(Container container)
    {
        containersList.Add(container);
        Console.WriteLine(container + " has been loaded on to the ship!");
    }
    
    public void loadManyContaiers(Container[] container)
    {
        for (int i = 0; i < container.Length; i++)
        {
            containersList.Add(container[i]);
            Console.WriteLine(container[i] + " has been loaded on to the ship!");
        }
    }
    
    public void unloadContaier(Container container)
    {
        containersList.Remove(container);
        Console.WriteLine(container + " has been unloaded on to the ship!");
    }
    
    public override string ToString()
    {
        return Name;
    }

    public void swapContainers(Container container1,Container container2, Ship ship1, Ship ship2 )
    {
        ship1.unloadContaier(container1);
        ship1.loadContaier(container2);
        ship2.unloadContaier(container2);
        ship2.loadContaier(container1);
        Console.WriteLine("Swapped container " + container1 + " from "+ ship1 + " with container " + container2 + " from " + ship2);
    }

    public void swapOnshipContainers(Container container1, Container container2)
    {
        (container1, container2) = (container2, container1);
        Console.WriteLine("Swapped " + container1 + " with container " + container2);
    }
    
    public void ShowShipInfo()
    {
        Console.WriteLine(
            "Name: " + Name +
            "\n" +
            "Max Cargo Weight: " + maxLoad  + 
            "\n" +
            "Max container count: " + maxContainerCount +
            "\n" +
            "Max speed: " + Speed + 
            "\n" +
            "Containers loaded: " + ContainersListListing(containersList)
        );
    }

    private static string ContainersListListing(List<Container> containersList)
    {
        string list = "";
        foreach (var container in containersList)
        {
            list += container;
            list += " , ";
        }

        return list;
    }
    
}