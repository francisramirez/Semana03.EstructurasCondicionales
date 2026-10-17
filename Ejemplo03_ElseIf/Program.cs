Console.Write("Ingrese la calificación: ");
decimal nota = decimal.Parse(Console.ReadLine()!);
if (nota < 0 || nota > 100)
{
    Console.WriteLine("Calificación inválida.");
}
else if (nota >= 90)
{
    Console.WriteLine("Excelente.");
}
else if (nota >= 80)
{
    Console.WriteLine("Muy bueno.");
}
else if (nota >= 70)
{
    Console.WriteLine("Aprobado.");
}
else
{
    Console.WriteLine("Reprobado.");
}
