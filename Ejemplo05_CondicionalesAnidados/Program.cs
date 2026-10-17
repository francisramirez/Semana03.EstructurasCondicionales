bool cuentaActiva = true;
decimal saldo = 5000m;
Console.Write("Ingrese el monto a retirar: ");
decimal retiro = decimal.Parse(Console.ReadLine()!);
if (cuentaActiva)
{
    if (retiro > 0)
    {
        if (saldo >= retiro)
        {
            saldo -= retiro;
            Console.WriteLine("Retiro exitoso.");
            Console.WriteLine($"Saldo disponible: RD${saldo:N2}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes.");
        }
    }
    else
    {
        Console.WriteLine("El monto debe ser mayor que cero.");
    }
}
else
{
    Console.WriteLine("La cuenta está inactiva.");
}
