string dilaia;

Console.Write("digite: ");
dilaia = Console.ReadLine()!.Replace("r", "l").Replace("R", "L");


Console.WriteLine($"Frase Cebolinha:  {dilaia}");