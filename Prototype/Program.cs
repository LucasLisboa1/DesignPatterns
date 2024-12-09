using Prototype;

var gamerComp = new GamerComputer();

gamerComp.HasRGB = true;
gamerComp.CPU = "AMD 2077";
gamerComp.GPU = "RTX 2060";
gamerComp.RAM = 20;
gamerComp.Motherboard = "amd1234";

var pcGamerClone = gamerComp.clone();

Console.WriteLine(pcGamerClone.HasRGB);
Console.WriteLine(pcGamerClone.CPU);
Console.WriteLine(pcGamerClone.GPU);
Console.WriteLine(pcGamerClone.RAM);
Console.WriteLine(pcGamerClone.Motherboard);
Console.WriteLine("\n");


var serverComp = new ServerComputer();

serverComp.NumberOfHDs = 10;
serverComp.CPU = "intel i5";
serverComp.GPU = "radeon 2";
serverComp.RAM = 100;
serverComp.Motherboard = "intel234";

var pcServerClone = serverComp.clone();

Console.WriteLine(serverComp.NumberOfHDs);
Console.WriteLine(serverComp.CPU);
Console.WriteLine(serverComp.GPU);
Console.WriteLine(serverComp.RAM);
Console.WriteLine(serverComp.Motherboard);