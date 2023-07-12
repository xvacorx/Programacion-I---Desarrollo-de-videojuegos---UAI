//1. Empleando arreglos mostrar los nombres de 4 alumnos con sus respectivas notas finales.

object[,] Notas = new object[2, 4];

for (int i = 0; i < Notas.GetLength(1); i++)
{
    Console.WriteLine("Ingrese nombre del alumno:");
    Notas[0, i] = Console.ReadLine();

    Console.WriteLine("Ingrese nota del alumno:");
    Notas[1, i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < Notas.GetLength(1); i++)
{
    Console.WriteLine("El alumno {0} tiene un {1}", Notas[0, i], Notas[1, i]);
}
