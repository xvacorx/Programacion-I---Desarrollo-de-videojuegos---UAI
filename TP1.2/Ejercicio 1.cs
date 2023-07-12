//1. Dados como datos cinco números reales obtener el promedio de los mismos e informar el resultado.

Console.WriteLine("Ingresar primer número: ");
int Numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar segundo número: ");
int Numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar tercer número: ");
int Numero3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar cuarto número: ");
int Numero4 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar quinto número: ");
int Numero5 = int.Parse(Console.ReadLine());

float promedio = (Numero1 + Numero2 + Numero3 + Numero4 + Numero5)/5;

Console.WriteLine("El promedio es de" + promedio);
