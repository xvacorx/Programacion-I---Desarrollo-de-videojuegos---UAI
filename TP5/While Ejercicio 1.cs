//1. Calcular e imprimir la suma de los números impares hasta ingresar 0.

int Suma = 0;

Console.WriteLine("Ingrese un número (ingrese 0 para salir)");
int Numero = int.Parse(Console.ReadLine());

while (Numero > 0)
{
    if (Numero % 2 != 0) { Suma += Numero; }

    Console.WriteLine("Ingrese un número (ingrese 0 para salir)");
    Numero = int.Parse(Console.ReadLine());
}

Console.WriteLine("El total de los números impares ingresados es de " + Suma);
