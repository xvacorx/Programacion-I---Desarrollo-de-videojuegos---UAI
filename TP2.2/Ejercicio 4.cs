//4. Determinar si el primero de un conjunto de tres números dados, es menor que los otros dos.

Console.WriteLine("Ingrese primer número");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo número");
int N2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese tercer número");
int N3 = int.Parse(Console.ReadLine());

if (N1 < N2 && N1 < N3) { Console.WriteLine("El primer numero es menor que el resto"); }
else { Console.WriteLine("El primer numero no es menor que el resto"); }
