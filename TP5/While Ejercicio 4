//4. Generar e imprimir los primeros 5 números primos.

Console.WriteLine("Mostrar los primeros 5 números primos:");
Console.ReadLine();

int contador = 0;
int numero = 2;

while (contador < 5)
{
    bool esPrimo = true;
    int divisor = 2;

    while (divisor <= Math.Sqrt(numero))
    {
        if (numero % divisor == 0)
        {
            esPrimo = false;
        }
        divisor++;
    }

    if (esPrimo)
    {
        Console.WriteLine(numero);
        contador++;
    }
    numero++;
}
