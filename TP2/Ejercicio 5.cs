//5. Ingresar cuatro valores, sumar el 1ro y el 2do, el 3ro y el 4to
//indicar e imprimir cuál de estas sumas es mayor

Console.WriteLine("Ingrese primer valor");
int V1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo valor");
int V2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese tercer valor");
int V3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cuarto valor");
int V4 = int.Parse(Console.ReadLine());

int Suma1 = V1 + V2;
int Suma2 = V3 + V4;

if (Suma1 > Suma2) {
    Console.WriteLine("La suma entre los valores 1 y 2 es mayor"); }

else if (Suma2 > Suma1) {
    Console.WriteLine("La suma entre los vlaores 3 y 4 es mayor"); }

else {
    Console.WriteLine("Las sumas dan el mismo resultado"); }
