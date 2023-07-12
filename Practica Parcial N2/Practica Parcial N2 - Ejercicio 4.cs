//4.Ingresar 5 números mediante un arreglo e indicar el menor número y el número más alto con sus respectivo índice.

int[] Arreglo = new int[5];
int Mayor = 0;
int Menor = 0;
int IndiceMayor  = 0;
int IndiceMenor  = 0;

for (int i = 0; i < Arreglo.Length; i++)
{
    Arreglo[i] = int.Parse(Console.ReadLine());
    if (Arreglo[i] > Mayor) { Mayor = Arreglo[i]; IndiceMayor = i; }
    if (Arreglo[i] < Menor || Menor == 0) { Menor = Arreglo[i]; IndiceMenor = i; }
}

Console.WriteLine("El número mas alto fue {0} en la posición {1}.", Mayor, IndiceMayor);
Console.WriteLine("El número mas bajo fue {0} en la posición {1}.", Menor, IndiceMenor);
