//1. Ingresar N sueldos e indicar su suma y su promedio, imprimir resultados

int Total = 0;
int Cantidad = 0;

Console.WriteLine("Ingrese monto del sueldo (Ingrese 0 para salir): ");
int Sueldo = int.Parse(Console.ReadLine());

while (Sueldo != 0)
{
    Total += Sueldo;
    Cantidad++;

    Console.WriteLine("Ingrese monto del sueldo (Ingrese 0 para salir): ");
    Sueldo = int.Parse(Console.ReadLine());
}

int Promedio = Total / Cantidad;

Console.WriteLine("Se ingresaron " + Cantidad + " de sueldos. Por un total de " + Total);
Console.WriteLine("Con un promedio de $" +  Promedio);
