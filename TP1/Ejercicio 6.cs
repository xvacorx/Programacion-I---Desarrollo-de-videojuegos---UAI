//6.Ingresar los lados de un rectángulo y calcular:
//su diagonal principal, superficie y perímetro. Imprimir los resultados solicitados.

--------- Con int----------

Console.WriteLine("Ingrese Base del rectángulo: ");
int Base = int.Parse((Console.ReadLine()));

Console.WriteLine("Ingrese Altura del rectángulo: ");
int Altura = int.Parse(Console.ReadLine());

int Base2 = (int)Math.Pow(Base, 2);
int Altura2 = (int)Math.Pow(Altura, 2);

int Hipotenusa2 = Base2 + Altura2;
int Hipotenusa = (int)Math.Sqrt(Hipotenusa2);

int Superficie = Base * Altura;

int Perimetro = Base * 2 + Altura * 2;

Console.WriteLine("La diagonal principal es de: " + Hipotenusa);
Console.WriteLine("La superficie es de: " + Superficie);
Console.WriteLine("El perimetro es de: " + Perimetro);


------------ con float-------------

Console.WriteLine("Ingrese Base del rectángulo: ");
float Base = float.Parse((Console.ReadLine()));

Console.WriteLine("Ingrese Altura del rectángulo: ");
float Altura = float.Parse(Console.ReadLine());

float Base2 = (float)Math.Pow(Base, 2);
float Altura2 = (float)Math.Pow(Altura, 2);

float Hipotenusa2 = Base2 + Altura2;
float Hipotenusa = (float)Math.Sqrt(Hipotenusa2);

float Superficie = Base * Altura;

float Perimetro = Base * 2 + Altura * 2;

Console.WriteLine("La diagonal principal es de: " + Hipotenusa);
Console.WriteLine("La superficie es de: " + Superficie);
Console.WriteLine("El perimetro es de: " + Perimetro);
