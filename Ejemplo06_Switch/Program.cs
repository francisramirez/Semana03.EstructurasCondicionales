Console.WriteLine("===== MENÚ PRINCIPAL =====");
Console.WriteLine("1. Consultar saldo");
Console.WriteLine("2. Depositar");
Console.WriteLine("3. Retirar");
Console.WriteLine("4. Salir");
Console.Write("Seleccione una opción: ");
int opcion = int.Parse(Console.ReadLine()!);
switch (opcion)
{
    case 1:
        Console.WriteLine("Ha seleccionado consultar saldo.");
        break;
    case 2:
        Console.WriteLine("Ha seleccionado depositar.");
        break;
    case 3:
        Console.WriteLine("Ha seleccionado retirar.");
        break;
    case 4:
        Console.WriteLine("Saliendo del sistema...");
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}
