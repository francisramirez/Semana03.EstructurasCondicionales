Console.WriteLine("===== CAJERO AUTOMÁTICO =====");
decimal saldo = 15000m;
bool cuentaActiva = true;
Console.WriteLine($"Saldo disponible: RD${saldo:N2}");
Console.Write("Ingrese el monto a retirar: ");
string? entrada = Console.ReadLine();
if (decimal.TryParse(entrada, out decimal retiro))
{
    if (!cuentaActiva)
    {
        Console.WriteLine("La cuenta se encuentra inactiva.");
    }
    else if (retiro <= 0)
    {
        Console.WriteLine("El monto debe ser mayor que cero.");
    }
    else if (retiro > saldo)
    {
        Console.WriteLine("Fondos insuficientes.");
    }
    else
    {
        saldo -= retiro;
        Console.WriteLine("Retiro realizado correctamente.");
        Console.WriteLine($"Monto retirado: RD${retiro:N2}");
        Console.WriteLine($"Nuevo saldo: RD${saldo:N2}");
    }
}
else
{
    Console.WriteLine("El monto ingresado no es válido.");
}
