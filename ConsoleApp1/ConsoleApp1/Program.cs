using ConsoleApp1;
using ConsoleApp1.Containers;


LiquidContainer LiquidContainer01 = new LiquidContainer(20, 30, 300, 2000,2000, true);
GasContainer GasContainer01 = new GasContainer(200, 200, 20, 200, 200, 200);
CoolingContainer CoolingContainer01 = new CoolingContainer(200, 200, 200, 200, 2000, "bananas", 20);
LiquidContainer LiquidContainer02 = new LiquidContainer(20, 30, 300, 2000,2000, true);
GasContainer GasContainer02 = new GasContainer(200, 200, 20, 200, 200, 200);
CoolingContainer CoolingContainer02 = new CoolingContainer(200, 200, 200, 200, 2000, "ice cream", 20);
LiquidContainer01.ShowContainerInfo();
LiquidContainer02.ShowContainerInfo();
GasContainer01.ShowContainerInfo();
GasContainer02.ShowContainerInfo();
CoolingContainer01.ShowContainerInfo();
CoolingContainer02.ShowContainerInfo();
Ship ship01 = new Ship(20, 20, 400000, "Czarna Perla");
Ship ship02 = new Ship(20, 20, 400000, "Latajacy hoe-lender");
ship01.loadContaier(LiquidContainer01);
ship01.loadContaier(LiquidContainer02);
ship01.loadContaier(CoolingContainer01);
ship01.loadContaier(GasContainer02);
ship01.ShowShipInfo();