//4. Ingresar tres valores, sumarlos, calcular el promedio e indicar e imprimir
//cuál de estos valores es mayor al promedio

Console.WriteLine("Ingrese primer valor:");
int V1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo valor:");
int V2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese tercer valor:");
int V3  = int.Parse(Console.ReadLine());

int Suma = V1 + V2 + V3;
float Promedio = Suma / 3;

Console.WriteLine("El promedio es: " + Promedio);

if (V1 > Promedio) { Console.WriteLine("El valor 1 es mayor al promedio"); }
if (V2 > Promedio) { Console.WriteLine("El valor 2 es mayor al promedio"); }
if (V3 > Promedio) { Console.WriteLine("El valor 3 es mayor al promedio"); }
