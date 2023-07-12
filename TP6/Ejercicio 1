//1. Ingresar datos y cargar un vector de 50 elementos, calcular
//• La suma de todos los elementos.
//• El producto de todos los elementos.
//• Mostrar del vector el elemento 50 al 1.
//• Imprimir las componentes de indice par.
//• Imprimir las componentes de indice impar.

int[] Vector =  new int[50];
int Suma = 0;
int Producto = 1;

Console.WriteLine("Ingrese 50 números");

for (int i = 0; i < Vector.Length; i++)
{
    Vector[i] = int.Parse(Console.ReadLine());
    Suma += Vector[i];
    Producto *= Vector[i];
}

Console.WriteLine("La suma de todos los elementos es de: " + Suma);
Console.WriteLine("El producto de todos los elementos es de: " + Producto);

Console.WriteLine("Mostrando elementos del 50 al 1:");

for (int i = 49; i > -1; i--)
{
    Console.WriteLine(Vector[i]);
}

Console.WriteLine("Mostrando los números de indice par:");

for (int i =  0; i < Vector.Length; i++)
{
    if (Vector[i] % 2 == 0) { Console.WriteLine(Vector[i]); }
}

Console.WriteLine("Mostrando los números de indice impar:");

for (int i = 0; i < Vector.Length; i++)
{
    if (Vector[i] % 2 != 0) { Console.WriteLine(Vector[i]); }
}
