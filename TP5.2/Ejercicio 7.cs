//7. Desarrolle un programa que pida al usuario los datos de dos matrices de 2x2
//y calcule y muestre su producto. Investigue como obtener el producto de dos matrices.

int[,] matriz1 = new int[2, 2];
int[,] matriz2 = new int[2, 2];
int[,] resultado = new int[2, 2];

Console.WriteLine("Ingrese los valores de la primera matriz:");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write("Ingrese el valor para la posición [{0},{1}]: ", i, j);
        matriz1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ingrese los valores de la segunda matriz:");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write("Ingrese el valor para la posición [{0},{1}]: ", i, j);
        matriz2[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        resultado[i, j] = 0;
        for (int k = 0; k < 2; k++)
        {
            resultado[i, j] += matriz1[i, k] * matriz2[k, j];
        }
    }
}
Console.WriteLine("El resultado del producto de las matrices es:");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write("{0} ", resultado[i, j]);
    }
    Console.WriteLine();
}
