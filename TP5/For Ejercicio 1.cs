//1. Calcular la suma de 10 números reales ingresados por teclado. Informar el resultado.

float Suma = 0;

Console.WriteLine("Ingrese 10 números:");

for (int i = 0; i < 10; i++)
{
    Suma += float.Parse(Console.ReadLine());
}

Console.WriteLine("La suma total es de: " + Suma);
