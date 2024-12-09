using Builder;

Computer comp = new ComputerBuilder().CPU("Inte i5")
                                     .MotherBoard("teste")
                                     .RAM(5)
                                     .build();

Console.WriteLine(comp.CPU);
Console.WriteLine(comp.Motherboard);
Console.WriteLine(comp.GPU);
Console.WriteLine(comp.RAM);

