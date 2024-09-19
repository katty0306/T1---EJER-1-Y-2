int verde = 0, azul = 0, rojo = 0;

Console.WriteLine("Ingrese el ultimo digito de la placa del carro: ");
while (true)
{
    string input = Console.ReadLine();
    if (input.ToUpper() == "F")
        break;

    int digit = int.Parse(input);

    if (digit >= 0 && digit <= 3)
        verde++;
    else if (digit >= 4 && digit <= 6)
        azul++;
    else if (digit >= 7 && digit <= 9)
        rojo++;
    else
        Console.WriteLine("Digito no valido !!! Intentelo nuevamente");
}

Console.WriteLine("Resultados: ");
Console.WriteLine($"Autos verdes: {verde}");
Console.WriteLine($"Autos azul: {azul}");
Console.WriteLine($"Autos rojos: {rojo}");
Console.ReadKey();
