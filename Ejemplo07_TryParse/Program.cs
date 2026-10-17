Console.Write("Ingrese su edad: ");
string? entrada = Console.ReadLine();
if (int.TryParse(entrada, out int edad))
{
    if (edad >= 18)
    {
        Console.WriteLine("Es mayor de edad.");
    }
    else if (edad >= 0)
    {
        Console.WriteLine("Es menor de edad.");
    }
    else
    {
        Console.WriteLine("La edad no puede ser negativa.");
    }
}
else
{
    Console.WriteLine("Debe ingresar un número válido.");
}
