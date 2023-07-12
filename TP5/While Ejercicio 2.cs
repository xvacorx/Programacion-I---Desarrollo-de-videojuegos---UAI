//2. Solicitar al usuario que ingrese números positivos y calcular e imprimir su promedio.
//El bucle debe terminar cuando se ingrese un número negativo.

int Total = 0;
int Cantidad = 0;

Console.WriteLine("Ingrese números positivos (ingrese un negativo para salir)");
int Numero = int.Parse(Console.ReadLine());

while  (Numero > -1)
{
    Total += Numero;
    Cantidad++;
    Console.WriteLine("Ingrese otro número (Ingrese un negativo para salir)");
    Numero = int.Parse(Console.ReadLine());
}

int Promedio = Total / Cantidad;

Console.WriteLine("Se ingresaron " + Cantidad + " de números, con un promedio de " + Promedio);
