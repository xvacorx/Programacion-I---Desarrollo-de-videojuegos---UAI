//5. Ingresar la patente y monto de la multa de 50 autos,
//indicar e imprimir cuántos montos superan los $ 40
//y del total cobrado que porcentaje representa la suma de los que superan los $40

float Total = 0;
float MasDe40 = 0;
float TotalMas40 = 0;

for (int i = 0; i < 30; i++)
{
    Console.WriteLine("Ingrese patente:");
    string Patente = Console.ReadLine();

    Console.WriteLine("Ingrese monto de multa:");
    float Monto = float.Parse(Console.ReadLine());

    Total += Monto;

    if (Monto > 40) { MasDe40++; TotalMas40 += Monto; }
}

double Porcentaje = ((double)TotalMas40 / Total) * 100;

Console.WriteLine("El total cobrado por multas es de: " + Total);
Console.WriteLine("La cantidad de multas que exceden los $40 es de: " +  MasDe40 + ", lo que nos dá un total de: " + TotalMas40);
Console.WriteLine("El ingreso de las multas superiores a $40 es del " +  Porcentaje + "% del total");
