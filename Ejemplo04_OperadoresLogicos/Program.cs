bool cuentaActiva = true;
decimal saldo = 10000m;
Console.Write("Ingrese el monto a retirar: ");
decimal retiro = decimal.Parse(Console.ReadLine()!);
if (cuentaActiva && retiro > 0 && saldo >= retiro)
{
    saldo -= retiro;
    Console.WriteLine("Retiro realizado correctamente.");
    Console.WriteLine($"Nuevo saldo: RD${saldo:N2}");
}
else
{
    Console.WriteLine("No es posible realizar el retiro.");
}
