//2. Ingresar por pantalla los nombres, apellidos, edad y sexo de cinco clientes, emplee los tipos de datos en arreglos.

object[,] Datos = new object[4, 5];

for (int i = 0; i < Datos.GetLength(1); i++)
{
    Console.WriteLine("Ingrese Nombre del cliente:");
    Datos[0, i] = Console.ReadLine();

    Console.WriteLine("Ingrese Apellido del cliente:");
    Datos[1, i] = Console.ReadLine();

    Console.WriteLine("Ingrese edad del cliente:");
    Datos[2, i] = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese sexo del usuario (M - F):");
    Datos[3, i] = int.Parse(Console.ReadLine());
}

for  (int i = 0; i < Datos.GetLength(1); i++)
{
    for (int j = 0; j < Datos.GetLength(0); j++)
    {
        Console.WriteLine(j, i);
    }
}
