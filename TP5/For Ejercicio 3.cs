//3. Sumar los números naturales entre 100 y 300, e informar el resultado.

int Suma = 0;

Console.WriteLine("Calcular la suma de los números naturales entre 100 y 300");
Console.ReadLine();

for (int i = 100; i <= 300; i++)
{
    Suma += i;
}

Console.WriteLine("El total es de: " +  Suma);
