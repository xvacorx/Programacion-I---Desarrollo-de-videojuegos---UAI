//10.Ingresar 3 valores de 3 variables X, Y y Z. Se desea obtener una rotación de sus
//valores, es decir que el contenido de Z pase por X, el contenido de X pase a Y, y el
//contenido de Y pase a Z. Mostrar luego las variables en el mismo orden en que se ingresaron (X, Y, Z).
//Si el contenido de X fuera 10, el de Y fuera 15, y el de Z fuera 20
//indicar cómo sería la salida luego de mostrar según lo pedido en el párrafo anterior.

Console.WriteLine("Ingrese valor de X:");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese valor de Y:");
int Y = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese valor de Z:");
int Z = int.Parse(Console.ReadLine());

int Temp = Z;
Z = Y;
Y = X;
X = Temp;

Console.WriteLine("La rotación de valores quedaría:");
Console.WriteLine("X: " +  X);
Console.WriteLine("Y: " +  Y);
Console.WriteLine("Z: " +  Z);
