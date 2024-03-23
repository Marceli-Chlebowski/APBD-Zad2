using ConsoleApp1;
using ConsoleApp1.interfaces;

LiquidContainer LiquidContainer01 = new LiquidContainer(20, 30, 300, 2000,2000, true);
GasContainer GasContainer01 = new GasContainer(200, 200, 20, 200, 200, 200);



int? a = 1;
a = null;

Exception? ex = new Exception();
ex = null;

Console.WriteLine(ex.Message);
