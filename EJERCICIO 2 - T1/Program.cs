int verde = 0, azul = 0, rojo = 0;

Console.WriteLine("Ingrese el ultimo digito de la placa del carro: ");
while (true)
{
    string input = Console.ReadLine();
    if (input.ToUpper() == "F")
        break;

    int dgto = int.Parse(input);

    if (dgto >= 0 && dgto <= 3)
        verde++;
    else if (dgto >= 4 && dgto <= 6)
        azul++;
    else if (dgto >= 7 && dgto <= 9)
        rojo++;
    else
        Console.WriteLine("Digito no valido !!!");
}

Console.WriteLine("Resultados: ");
Console.WriteLine($"Autos verdes: {verde}");
Console.WriteLine($"Autos azul: {azul}");
Console.WriteLine($"Autos rojos: {rojo}");
Console.ReadKey();
