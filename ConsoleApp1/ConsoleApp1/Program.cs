using ConsoleApp1;

var container = new Container(10.0)
{
Cargoweight = 12.0
};

Container Lcontainer = new LiquidContainer(10);
container.Load(20);
Lcontainer.Load(30);

    int? a = 1;
a = null;

Exception? ex = new Exception();
ex = null;

Console.WriteLine(ex.Message);
