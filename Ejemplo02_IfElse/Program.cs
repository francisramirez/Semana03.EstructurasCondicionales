Console.Write("Ingrese su calificación: ");
decimal nota = decimal.Parse(Console.ReadLine()!);
if (nota >= 70)
{
    Console.WriteLine("Estudiante aprobado.");
}
else
{
    Console.WriteLine("Estudiante reprobado.");
}
