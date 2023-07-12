//6. Mostrar por pantalla las tablas de multiplicar del 1 al 6.

Console.WriteLine("Mostrar las tablas de multiplicar del 1 al 6");
Console.ReadLine();

for  (int i = 1; i < 7; i++)
{
    Console.WriteLine("Tabla del " +  i);
    for (int j = 1; j < 11; j++)
    {
        int Multiplo = i * j;
        Console.WriteLine(Multiplo);
    }
}
