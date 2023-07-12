//2. Ingresar 10 valores, indicar e imprimir cuántos son positivos, cuántos negativos y cuántos ceros

float Positivo = 0;
float Negativo = 0;
float Cero = 0;

Console.WriteLine("Ingrese 10 números:");
for (int i = 0; i < 10; i++)
{
    float Numero = float.Parse(Console.ReadLine());

    if (Numero > 0) { Positivo += 1; }
    else if (Numero < 0) { Negativo += 1; }
    else { Cero += 1; }
}

Console.WriteLine("La cantidad de números positivos es de: " +  Positivo);
Console.WriteLine("La cantidad de números negativos es de: " +  Negativo);
Console.WriteLine("La cantidad de ceros es de: " +  Cero);
